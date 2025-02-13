using Carter;

namespace The2PHouse.IdentityService.Presentation.Endpoints
{
    public abstract class EndpointBase : ICarterModule
    {
        private const string BaseRoute = "/api/auth";

        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var groupBuilder = app.MapGroup(BaseRoute);
            ConfigureRoutes(groupBuilder);
        }
        protected abstract void ConfigureRoutes(RouteGroupBuilder groupBuilder);
    }
}
