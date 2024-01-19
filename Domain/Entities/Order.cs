using System;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Order : Entity
{
    public int SubscriptionTier { get; set; } // Enum
    
    public int Status { get; set; } // Enum
    
    public DateTime CreateDate { get; set; }
    
    public User User { get; set; } = null!;   
}