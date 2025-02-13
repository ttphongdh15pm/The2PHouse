using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The2PHouse.IdentityService.Domain.Entities;

namespace The2PHouse.IdentityService.Infrastructure.Persistence.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.ToTable("roles");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).HasColumnName("id");
            builder.Property(r => r.Name)
                .IsRequired()
                .HasColumnType("nvarchar(100)")
                .HasColumnName("name");
            builder.Property(r => r.IsCustomize)
                .IsRequired()
                .HasColumnName("is_customize")
                .HasDefaultValue(false);
            builder.Property(r => r.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();
            builder.HasMany(r => r.UserRoles)
                .WithOne(ur => ur.Role)
                .HasForeignKey(ur => ur.RoleId);
            builder.HasMany(r => r.RoleActions)
                .WithOne(ra => ra.Role)
                .HasForeignKey(ra => ra.RoleId);
        }
    }
}
