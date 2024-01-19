using System;

namespace juttrips_azure_function.Infrastructure.DbConfiguration;

public static class DbMetaData
{
    public static string GetMySqlConnectionString()
    {
        var connectionString = Environment.GetEnvironmentVariable("ConnectionString");
        
        return connectionString ?? throw new NullReferenceException("ConnectionString not found");
    }
}