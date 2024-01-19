namespace juttrips_azure_function.API.Enum;

public static class AuthEndpoint
{
    private const string BaseEndpoint = "auth/";
    
    public const string RegisterName = "register";
    public const string RegisterEndPoint =  BaseEndpoint + "register";
    
}