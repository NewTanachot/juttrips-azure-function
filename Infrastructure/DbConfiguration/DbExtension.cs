using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace juttrips_azure_function.Infrastructure.DbConfiguration;

public static class DbExtension
{
    public static string GetMySqlConnectionString()
    {
        var connectionString = Environment.GetEnvironmentVariable("ConnectionString");
        
        return connectionString ?? throw new NullReferenceException("ConnectionString not found");
    }

    public static IServiceCollection AddJutTripsDbContext(this IServiceCollection services)
    {
        var connectionString = GetMySqlConnectionString();
        
        services.AddDbContext<JutTripsDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        
        return services;
    }
}