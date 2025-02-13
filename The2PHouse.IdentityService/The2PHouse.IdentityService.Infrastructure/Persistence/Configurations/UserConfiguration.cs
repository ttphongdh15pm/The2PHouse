using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The2PHouse.IdentityService.Domain.Entities;

namespace The2PHouse.IdentityService.Infrastructure.Persistence.Configurations
{
    internal sealed class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("users");
            builder.HasKey(u => u.Username);
            builder.Property(u => u.Username)
                .IsRequired()
                .HasColumnName("username")
                .HasColumnType("varchar(100)");
            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(255);
            builder.Property(u => u.CreatedAt)
               .HasColumnName("created_at")
               .IsRequired();
            builder.Property(u => u.PasswordHash)
                .HasColumnName("passwork_hash")
                .HasMaxLength(60)
                .IsRequired();
            builder.HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.Username);
        }
    }
}
