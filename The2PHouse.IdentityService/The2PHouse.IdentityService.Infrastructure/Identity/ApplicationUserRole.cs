using Microsoft.AspNetCore.Identity;

namespace The2PHouse.IdentityService.Infrastructure.Identity
{
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ApplicationRole Role { get; set; } = null!;
    }
}