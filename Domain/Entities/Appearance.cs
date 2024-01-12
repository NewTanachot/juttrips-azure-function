using System;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Appearance : PrimaryKey
{
    [MaxLength(50)] 
    public string? Image { get; set; }
    public int ThemeStyle { get; set; } // Enum
    public int ThemeColor { get; set; } // Enum
    public int MapStyle { get; set; } // Enum
    public int PlaceOrder { get; set; } // Enum
    public int GroupOrder { get; set; } // Enum
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
}