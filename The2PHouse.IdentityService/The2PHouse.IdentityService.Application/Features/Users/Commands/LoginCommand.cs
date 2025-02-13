using BuildingBlocks.CQRS;

namespace The2PHouse.IdentityService.Application.Features.Users.Commands
{
    public class LoginCommand : ICommand   
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

}
