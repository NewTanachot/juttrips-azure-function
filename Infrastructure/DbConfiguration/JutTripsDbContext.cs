using juttrips_azure_function.Domain.Entities;
using juttrips_azure_function.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace juttrips_azure_function.Infrastructure.DbConfiguration;

public class JutTripsDbContext : DbContext
{
    public DbSet<User> User { get; set; } = null!;

    public DbSet<Appearance> Appearance { get; set; } = null!;

    public DbSet<Card> Card { get; set; } = null!;

    public DbSet<Category> Category { get; set; } = null!;

    public DbSet<Group> Group { get; set; } = null!;

    public DbSet<UserGroup> UserGroup { get; set; } = null!;
    
    public DbSet<Place> Places { get; set; } = null!;

    public JutTripsDbContext(DbContextOptions<JutTripsDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
        // force mysql to use "utf8mb3"
        modelBuilder.UseCollation("utf8mb3_general_ci");
        
        modelBuilder.ApplyConfiguration(new UserGroupTypeConfiguration());
    }
}