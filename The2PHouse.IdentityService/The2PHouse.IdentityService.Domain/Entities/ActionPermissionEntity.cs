namespace The2PHouse.IdentityService.Domain.Entities
{
    public class ActionPermissionEntity
    {
        public Guid Id { get; set; } = Guid.CreateVersion7();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<RoleActionEntity> RoleActions { get; set; } = new();
        public List<CustomRoleActionEntity> CustomRoleActions { get; set; } = new();

    }
}