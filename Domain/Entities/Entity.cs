using System;
using System.ComponentModel.DataAnnotations;

namespace juttrips_azure_function.Domain.Entities;

public class Entity
{
    [Key]
    public Guid Id { get; set; } // auto generate key

    public DateTime CreateAt { get; set; } = DateTime.Now;

    public bool IsDeleted { get; set; } = false;
}