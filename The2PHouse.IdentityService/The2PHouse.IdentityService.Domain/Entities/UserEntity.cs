namespace The2PHouse.IdentityService.Domain.Entities
{
    public class UserEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public List<UserRoleEntity> UserRoles { get; set; } = new();
    }
}
