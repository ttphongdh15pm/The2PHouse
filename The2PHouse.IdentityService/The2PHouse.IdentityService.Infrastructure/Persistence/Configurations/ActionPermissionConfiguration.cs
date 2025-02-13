using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The2PHouse.IdentityService.Domain.Entities;

namespace The2PHouse.IdentityService.Infrastructure.Persistence.Configurations
{
    internal class ActionPermissionConfiguration : IEntityTypeConfiguration<ActionPermissionEntity>
    {
        public void Configure(EntityTypeBuilder<ActionPermissionEntity> builder)
        {
            builder.ToTable("action_permissions");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("id");

            builder.Property(a => a.Name)
                .HasColumnName("name")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(a => a.Description)
                .HasColumnName("description")
                .HasColumnType("nvarchar(500)");
        }
    }
}
