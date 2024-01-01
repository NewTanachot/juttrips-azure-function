using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace juttrips_azure_function.Infrastructure.DatabaseConfig;

public class DbContextFactory : IDesignTimeDbContextFactory<JutTripsDbContext>
{
    public JutTripsDbContext CreateDbContext(string[] args)
    {
        const string connectionString = DatabaseMetaData.ConnectionString;
        
        var optionsBuilder = new DbContextOptionsBuilder<JutTripsDbContext>();
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new JutTripsDbContext(optionsBuilder.Options);
    }
}