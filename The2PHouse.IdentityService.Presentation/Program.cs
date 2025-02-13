using Carter;
using The2PHouse.IdentityService.Infrastructure;
namespace The2PHouse.IdentityService.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.AddServiceDefaults();
    
            builder.Services.AddAuthorization();
            // Add services to the container.
            builder.Services.AddInfrastructure(builder.Configuration);

            var app = builder.Build();

            app.MapCarter();

            app.MapDefaultEndpoints();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run();
        }
    }
}
