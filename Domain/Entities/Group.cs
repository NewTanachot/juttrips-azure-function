using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Group : Entity
{
    public bool IsPublic { get; set; } = false;

    [MaxLength(50)] 
    public string OwnerUserId { get; set; } = string.Empty;

    public List<User>? Users { get; set; }
    
    public List<GroupPlace>? Places { get; set; }
}