namespace The2PHouse.IdentityService.Domain.Entities
{
    public class CustomRoleActionEntity
    {
        public Guid CustomRoleId { get; set; }
        public CustomRoleEntity CustomRole { get; set; } = null!;

        public Guid ActionId { get; set; }
        public ActionPermissionEntity ActionPermission { get; set; } = null!;
    }
}