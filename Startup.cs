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
        var mySqlConnectionString = DatabaseMetaData.GetMySqlConnectionString();
        
        // Add your DbContext registration
        builder.Services.AddDbContext<JutTripsDbContext>(options =>
            options.UseMySql(mySqlConnectionString, ServerVersion.AutoDetect(mySqlConnectionString)));
    }
}