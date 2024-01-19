using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Group : Entity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required] 
    [MaxLength(6)] 
    public string RefId { get; set; } = null!;
    
    [MaxLength(50)] 
    public string? Image { get; set; }
    
    public int? Sequence { get; set; }
    
    public bool IsPublic { get; set; } = false;
    
    public List<UserGroup>? UserGroups { get; set; }

    public List<Place> Places { get; set; } = new List<Place>();
}