namespace The2PHouse.IdentityService.Domain.Entities
{
    public class RoleActionEntity
    {
        public Guid RoleId { get; set; }
        public RoleEntity Role { get; set; } = null!;

        public Guid ActionId { get; set; }
        public ActionPermissionEntity ActionPermission { get; set; } = null!;

    }
}