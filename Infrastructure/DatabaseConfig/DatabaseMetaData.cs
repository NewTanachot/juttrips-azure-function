using System;

namespace juttrips_azure_function.Infrastructure.DatabaseConfig;

public static class DatabaseMetaData
{
    public static string GetMySqlConnectionString()
    {
        var connectionString = Environment.GetEnvironmentVariable("ConnectionString");
        return connectionString ?? throw new NullReferenceException("ConnectionString not found");
    }
}