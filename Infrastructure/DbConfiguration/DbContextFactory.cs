using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace juttrips_azure_function.Infrastructure.DbConfiguration;

public class DbContextFactory : IDesignTimeDbContextFactory<JutTripsDbContext>
{
    public JutTripsDbContext CreateDbContext(string[] args)
    {
        var mySqlConnectionString = DbExtension.GetMySqlConnectionString();
        
        var optionsBuilder = new DbContextOptionsBuilder<JutTripsDbContext>();
        optionsBuilder.UseMySql(mySqlConnectionString, ServerVersion.AutoDetect(mySqlConnectionString));
        
        return new JutTripsDbContext(optionsBuilder.Options);
    }
}