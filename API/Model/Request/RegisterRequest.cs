namespace juttrips_azure_function.API.Model.Request;

public class RegisterRequest
{
    public string? UserName { get; set; }
    
    public string? Email { get; set; } 
    
    public string? Password { get; set; }
    
    public string? PhoneNumber { get; set; }
}