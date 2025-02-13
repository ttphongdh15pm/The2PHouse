using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The2PHouse.IdentityService.Domain.Entities;

namespace The2PHouse.IdentityService.Infrastructure.Persistence.Configurations
{
    internal class CustomRoleConfiguration : IEntityTypeConfiguration<CustomRoleEntity>
    {
        public void Configure(EntityTypeBuilder<CustomRoleEntity> builder)
        {
            builder.HasKey(cr => cr.Id);
            builder.Property(cr => cr.Id).HasColumnName("id");
            builder.Property(cr => cr.CreatedBy).HasColumnName("create_by");
            builder.Property(cr => cr.CreatedAt).HasColumnName("create_at");
            builder.Property(cr => cr.RoleName)
                .IsRequired()
                .HasColumnName("role_name")
                .HasColumnType("nvarchar(100)");
            builder.HasOne(cr => cr.Creator)
                .WithMany()
                .HasForeignKey(cr => cr.CreatedBy);
        }
    }
}
