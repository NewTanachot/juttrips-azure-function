using System;
using System.ComponentModel.DataAnnotations;

namespace juttrips_azure_function.Domain.Entities.Base;

public class Entity : PrimaryKey
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime? DeleteDate { get; set; }
}