using juttrips_azure_function.Core.Repository;
using juttrips_azure_function.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace juttrips_azure_function.Infrastructure.DependencyInjection;

public static class RepositoryInjection
{
    public static IServiceCollection AddRepositoryInjection(this IServiceCollection services)
    {
        services.AddTransient<IAuthRepository, AuthRepository>();

        return services;
    }
}