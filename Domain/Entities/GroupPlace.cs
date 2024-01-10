using juttrips_azure_function.Domain.Entities.Base;

namespace juttrips_azure_function.Domain.Entities;

public class GroupPlace : Place
{
    public Group? Group { get; set; }
}