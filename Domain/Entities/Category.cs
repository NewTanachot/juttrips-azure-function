using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Category : Entity
{
    [Required]
    [MaxLength(50)] 
    public string Name { get; set; } = null!;
    
    [MaxLength(50)] 
    public string? Image { get; set; }
    
    public List<Place> Places { get; set; } = new List<Place>();
}