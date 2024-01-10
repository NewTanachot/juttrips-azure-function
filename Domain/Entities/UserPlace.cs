using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class UserPlace : Place
{
    public User? User { get; set; }
}