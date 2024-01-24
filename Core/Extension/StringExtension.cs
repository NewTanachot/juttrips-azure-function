using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace juttrips_azure_function.Core.Extension;

public static class StringExtension
{
    public static string ToSnakeCase(this string value)
    {
        return string.Concat(value.Select((c, i) => i > 0 && char.IsUpper(c)
                ? "_" + c.ToString()
                : c.ToString()))
            .ToLower();
    }

    public static byte[] Encrypt(this string plainText, string key, string nonce)
    {
        using var aesAlg = new AesGcm(Encoding.UTF8.GetBytes(key));
        var nonceBytes = Encoding.UTF8.GetBytes(nonce);

        byte[] cipherText = new byte[plainText.Length * sizeof(char)];
        byte[] tag = new byte[16]; // 16 bytes for authentication tag

        aesAlg.Encrypt(nonceBytes, Encoding.UTF8.GetBytes(plainText), cipherText, tag);

        // Combine nonce, cipherText, and tag into a single byte array
        var encryptedData = new byte[nonceBytes.Length + cipherText.Length + tag.Length];
        Buffer.BlockCopy(nonceBytes, 0, encryptedData, 0, nonceBytes.Length);
        Buffer.BlockCopy(cipherText, 0, encryptedData, nonceBytes.Length, cipherText.Length);
        Buffer.BlockCopy(tag, 0, encryptedData, nonceBytes.Length + cipherText.Length, tag.Length);

        return encryptedData;
    }

    public static string Decrypt(this byte[] encryptedData, string key)
    {
        using var aesAlg = new AesGcm(Encoding.UTF8.GetBytes(key));

        const int nonceLength = 12; // Assuming a 12-byte nonce is used
        var nonce = new byte[nonceLength];
        var cipherText = new byte[encryptedData.Length - nonceLength - 16]; // 16 bytes for authentication tag
        var tag = new byte[16];

        // Extract nonce, cipherText, and tag from the encryptedData
        Buffer.BlockCopy(encryptedData, 0, nonce, 0, nonceLength);
        Buffer.BlockCopy(encryptedData, nonceLength, cipherText, 0, cipherText.Length);
        Buffer.BlockCopy(encryptedData, nonceLength + cipherText.Length, tag, 0, tag.Length);

        // Decrypt the data
        var decryptedData = new byte[cipherText.Length];
        aesAlg.Decrypt(nonce, cipherText, tag, decryptedData);

        return Encoding.UTF8.GetString(decryptedData);
    }

    public static string GenerateNonce()
    {
        using var rng = RandomNumberGenerator.Create();
        var nonceBytes = new byte[12]; // 12 bytes for AES GCM nonce
        rng.GetBytes(nonceBytes);

        return Convert.ToBase64String(nonceBytes);
    }
}