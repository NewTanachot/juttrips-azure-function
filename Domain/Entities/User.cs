using System.ComponentModel.DataAnnotations;

namespace juttrips_azure_function.Domain.Entities;

public class User : Entity
{
    [MaxLength(30)]
    public string UserName { get; set; } = string.Empty;
    
    [MaxLength(30)]
    public string Password { get; set; } = string.Empty;
    
    [MaxLength(30)]
    public string IvKey { get; set; } = string.Empty;
    
    public int ThemeStyle { get; set; }
    
    public int ThemeColor { get; set; }
    
    public int MapStyle { get; set; }
}