using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace juttrips_azure_function.Infrastructure.DatabaseConfig;

public class DbContextFactory : IDesignTimeDbContextFactory<JutTripsDbContext>
{
    public JutTripsDbContext CreateDbContext(string[] args)
    {
        var mySqlConnectionString = DatabaseMetaData.GetMySqlConnectionString();
        
        var optionsBuilder = new DbContextOptionsBuilder<JutTripsDbContext>();
        optionsBuilder.UseMySql(mySqlConnectionString, ServerVersion.AutoDetect(mySqlConnectionString));
        
        return new JutTripsDbContext(optionsBuilder.Options);
    }
}