using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class User : Entity
{
    [Required] 
    [MaxLength(50)] 
    public string Password { get; set; } = string.Empty;
    
    [Required] 
    [MaxLength(50)]
    public string IvKey { get; set; } = string.Empty;
    
    public int ThemeStyle { get; set; } // Enum
    
    public int ThemeColor { get; set; } // Enum
    
    public int MapStyle { get; set; } // Enum

    public int SubscriptionTier { get; set; } // Enum

    public DateTime? SubscriptionExpireDate { get; set; }

    public List<Group>? Groups { get; set; }
    
    public List<UserPlace>? Places { get; set; }
}