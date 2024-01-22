using System;
using System.Threading.Tasks;
using juttrips_azure_function.API.Model.Request;
using juttrips_azure_function.Core.Interface;
using juttrips_azure_function.Core.Repository;
using juttrips_azure_function.Domain.Entities;

namespace juttrips_azure_function.Core.Service;

public class AuthService : IAuthService
{
    private readonly IAuthRepository _authRepository;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository ?? throw new ArgumentNullException(nameof(authRepository));
    }

    public Task<User> CreateUserAsync(RegisterRequest register)
    {
        throw new NotImplementedException();
    }
}