using juttrips_azure_function.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace juttrips_azure_function.Infrastructure.DatabaseConfig;

public class JutTripsDbContext : DbContext
{
    public DbSet<User> User { get; set; } = null!;

    public DbSet<Group> Group { get; set; } = null!;

    public DbSet<UserPlace> UserPlace { get; set; } = null!;

    public DbSet<GroupPlace> GroupPlace { get; set; } = null!;

    public JutTripsDbContext(DbContextOptions<JutTripsDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
        // force mysql to use "utf8mb3"
        modelBuilder.UseCollation("utf8mb3_general_ci");
    }
}