using juttrips_azure_function;
using juttrips_azure_function.Infrastructure.DbConfiguration;
using juttrips_azure_function.Infrastructure.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace juttrips_azure_function;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddJutTripsDbContext();
        builder.Services.AddServiceInjection();
        builder.Services.AddRepositoryInjection();
    }
}