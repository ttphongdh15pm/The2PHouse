namespace The2PHouse.IdentityService.Domain.Entities
{
    public class RoleEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public bool IsCustomize { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<UserRoleEntity> UserRoles { get; set; } = new();
        public List<RoleActionEntity> RoleActions { get; set; } = new();
    }
}