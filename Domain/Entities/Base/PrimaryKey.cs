using System;
using System.ComponentModel.DataAnnotations;

namespace juttrips_azure_function.Domain.Entities.Base;

public class PrimaryKey
{
    [Key]
    public Guid Id { get; set; } // auto generate key
}