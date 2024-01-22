using juttrips_azure_function.Core.Interface;
using juttrips_azure_function.Core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace juttrips_azure_function.Infrastructure.DependencyInjection;

public static class ServiceInjection
{
    public static IServiceCollection AddServiceInjection(this IServiceCollection services)
    {
        services.AddTransient<IAuthService, AuthService>();
        
        return services;
    }
}