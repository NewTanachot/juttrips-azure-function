using juttrips_azure_function.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace juttrips_azure_function.Infrastructure.EntityConfiguration;

public class UserGroupTypeConfiguration : IEntityTypeConfiguration<UserGroup>
{
    public void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        // set composite primary key
        builder.HasKey(ug => new { ug.UserId, ug.GroupId });
    }
}