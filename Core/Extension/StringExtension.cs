using System.Linq;

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
}