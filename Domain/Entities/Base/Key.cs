using System;
using System.ComponentModel.DataAnnotations;

namespace juttrips_azure_function.Domain.Entities.Base;

public class Key
{
    [Key]
    public Guid Id { get; set; } // auto generate key
}