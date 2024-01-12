using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Group : Entity
{
    [MaxLength(50)] 
    public string? Image { get; set; }
    public int? Sequence { get; set; }
    public bool IsPublic { get; set; } = false;
    public List<UserGroup>? UserGroups { get; set; }
    public List<GroupPlace>? Places { get; set; }
}