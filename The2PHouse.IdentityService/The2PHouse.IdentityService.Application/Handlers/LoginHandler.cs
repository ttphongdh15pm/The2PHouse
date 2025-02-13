using BuildingBlocks.CQRS;
using MediatR;
using The2PHouse.IdentityService.Application.Features.Users.Commands;

namespace The2PHouse.IdentityService.Application.Handlers
{
    public sealed class LoginHandler : ICommandHandler<LoginCommand>
    {
        public Task<Unit> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
