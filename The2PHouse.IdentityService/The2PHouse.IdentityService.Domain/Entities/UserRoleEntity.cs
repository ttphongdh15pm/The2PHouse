namespace The2PHouse.IdentityService.Domain.Entities
{
    public class UserRoleEntity
    {
        public string Username { get; set; } = string.Empty;
        public UserEntity User { get; set; } = null!;
        public Guid RoleId { get; set; }
        public RoleEntity Role { get; set; } = null!;
    }
}