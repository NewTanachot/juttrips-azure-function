using System;
using System.ComponentModel.DataAnnotations;
using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class Card : PrimaryKey
{
    [Required] 
    [MaxLength(50)] 
    public string Name { get; set; } = null!;
    [Required] 
    [MaxLength(30)] 
    public string Number { get; set; } = null!;
    [Required] 
    public int Cvv { get; set; }
    [Required] 
    public int ExpireMonth { get; set; }
    [Required] 
    public int ExpireYear { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
}