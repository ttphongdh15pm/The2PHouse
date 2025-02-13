using Microsoft.AspNetCore.Identity;

namespace The2PHouse.IdentityService.Infrastructure.Identity
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }
}