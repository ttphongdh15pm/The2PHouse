using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The2PHouse.IdentityService.Domain.Entities;

namespace The2PHouse.IdentityService.Infrastructure.Persistence.Configurations
{
    internal class RoleActionConfiguration : IEntityTypeConfiguration<RoleActionEntity>
    {
        public void Configure(EntityTypeBuilder<RoleActionEntity> builder)
        {
            builder.ToTable("roles_actions");
            builder.Property(ra => ra.RoleId).HasColumnName("role_id");
            builder.Property(ra => ra.ActionId).HasColumnName("action_id");
            builder.HasKey(ra => new { ra.RoleId, ra.ActionId });
            builder.HasOne(ra => ra.Role)
                .WithMany(r => r.RoleActions)
                .HasForeignKey(ra => ra.RoleId);
            builder.HasOne(ra => ra.ActionPermission)
                .WithMany(a => a.RoleActions)
                .HasForeignKey(ra => ra.ActionId);
        }
    }
}
