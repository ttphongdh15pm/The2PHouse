using Carter;

namespace The2PHouse.IdentityService.Presentation.Endpoints
{
    public class AuthEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/auth");

            //group.MapPost("/register", async ([FromBody] CreateUserCommand request, IMediator mediator) =>
            //{
            //    var result = await mediator.Send(request);
            //    return Results.Ok(new { UserId = result });
            //})
            //.WithName("RegisterUser")
            //.WithTags("Authentication");

            //group.MapPost("/login", async ([FromBody] LoginUserCommand request, IMediator mediator) =>
            //{
            //    var result = await mediator.Send(request);
            //    return result != null
            //        ? Results.Ok(new { Token = result })
            //        : Results.Unauthorized();
            //})
            //.WithName("LoginUser")
            //.WithTags("Authentication");
        }
    }
}
