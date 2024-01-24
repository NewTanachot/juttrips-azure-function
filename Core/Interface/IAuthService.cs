using System.Threading.Tasks;
using juttrips_azure_function.API.Model.Request;
using juttrips_azure_function.Domain.Entities;

namespace juttrips_azure_function.Core.Interface;

public interface IAuthService
{
    Task<User> CreateUserAsync(RegisterRequest register);
}