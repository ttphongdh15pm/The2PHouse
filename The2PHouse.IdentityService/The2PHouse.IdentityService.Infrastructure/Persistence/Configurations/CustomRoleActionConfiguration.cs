using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The2PHouse.IdentityService.Domain.Entities;

namespace The2PHouse.IdentityService.Infrastructure.Persistence.Configurations
{
    internal class CustomRoleActionConfiguration : IEntityTypeConfiguration<CustomRoleActionEntity>
    {
        public void Configure(EntityTypeBuilder<CustomRoleActionEntity> builder)
        {
            builder.ToTable("custom_roles_actions");
            builder.Property(cra => cra.CustomRoleId).HasColumnName("custom_role_id");
            builder.Property(cra => cra.ActionId).HasColumnName("action_id");
            builder.HasKey(cra => new { cra.CustomRoleId, cra.ActionId });
            builder.HasOne(cra => cra.CustomRole)
                .WithMany(cr => cr.CustomRoleActions)
                .HasForeignKey(cra => cra.CustomRoleId);
            builder.HasOne(cra => cra.ActionPermission)
                .WithMany(a => a.CustomRoleActions)
                .HasForeignKey(cra => cra.ActionId);
        }
    }
}
