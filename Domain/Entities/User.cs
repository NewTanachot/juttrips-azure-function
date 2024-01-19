using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class User : Entity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required] 
    [MaxLength(50)] 
    public string Password { get; set; } = string.Empty;
    
    [EmailAddress] 
    [MaxLength(50)] 
    public string? Email { get; set; }
    
    [MaxLength(20)] 
    public string? PhoneNumber { get; set; }
    
    [Required] 
    [MaxLength(50)]
    public string IvKey { get; set; } = string.Empty;
    
    public int SubscriptionTier { get; set; } // Enum
    
    public DateTime? SubscriptionExpireDate { get; set; }
    
    public Card? Card { get; set; }
    
    public Appearance Appearance { get; set; } = null!;
    
    public List<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
    
    public List<Place> Places { get; set; } = new List<Place>();
}