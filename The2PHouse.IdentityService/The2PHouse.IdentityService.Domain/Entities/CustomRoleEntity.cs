namespace The2PHouse.IdentityService.Domain.Entities
{
    public class CustomRoleEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RoleName { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public UserEntity Creator { get; set; } = null!;
        public List<CustomRoleActionEntity> CustomRoleActions { get; set; } = new();
    }
}