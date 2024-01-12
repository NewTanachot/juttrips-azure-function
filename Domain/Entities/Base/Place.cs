using System;
using System.ComponentModel.DataAnnotations;

namespace juttrips_azure_function.Domain.Entities.Base;

public class Place : Entity
{
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    [MaxLength(100)]
    public string? Description { get; set; }
    public int? Sequence { get; set; }
    public DateTime? AppointedDate { get; set; }
    public bool IsDisplay { get; set; } = true;
}