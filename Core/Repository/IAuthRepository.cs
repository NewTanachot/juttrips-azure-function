using System.Threading.Tasks;
using juttrips_azure_function.Domain.Entities;

namespace juttrips_azure_function.Core.Repository;

public interface IAuthRepository
{
    Task<User> InsertUserAsync(User user);
}