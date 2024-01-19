using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Place : Entity
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(100)]
    public string? Description { get; set; }
    
    public double? Latitude { get; set; }
    
    public double? Longitude { get; set; }
    
    public int? Sequence { get; set; }
    
    public bool IsDisplay { get; set; }
    
    public DateTime? AppointedDate { get; set; }
    
    public DateTime CreateDate { get; set; }
    
    public User? User { get; set; }
    
    public Group? Group { get; set; }

    public List<Category> Categories { get; set; } = new List<Category>();
}