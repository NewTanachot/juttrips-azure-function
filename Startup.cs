using juttrips_azure_function;
using juttrips_azure_function.Infrastructure.DatabaseConfig;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace juttrips_azure_function;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddDbContext<JutTripsDbContext>(options =>
        {
            const string connectionString = DatabaseMetaData.ConnectionString;
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
    }
}