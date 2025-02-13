using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace The2PHouse.IdentityService.Presentation.Endpoints
{
    public class RegisterEnpoint : EndpointBase
    {
        protected override void ConfigureRoutes(RouteGroupBuilder groupBuilder)
        {
            //groupBuilder.MapPost("/register", async ([FromBody] CreateUserCommand request, IMediator mediator) =>
            //{
            //    var result = await mediator.Send(request);
            //    return Results.Ok(new { UserId = result });
            //})
            //.WithName("RegisterUser")
            //.WithTags("Authentication");
        }
    }
}
