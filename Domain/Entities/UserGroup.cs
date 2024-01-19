using System;

namespace juttrips_azure_function.Domain.Entities;

public class UserGroup
{
    public bool IsOwner { get; set; }
    
    public bool IsModerator { get; set; }
    
    public Guid UserId { get; set; }
    
    public User User { get; set; } = null!;
    
    public Guid GroupId { get; set; }
    
    public Group Group { get; set; } = null!;
}