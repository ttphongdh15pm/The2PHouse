using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BuildingBlocks.Messaging.MassTransit
{
    public static class Extensions
    {
        public static IServiceCollection AddMessageBroker(this IServiceCollection services, IConfiguration configuration, Assembly? assembly = null)
        {
            var rabbitMqHost = configuration["MessageBroker:Host"];
            var username = configuration["MessageBroker:UserName"];
            var password = configuration["MessageBroker:Password"];

            if (string.IsNullOrWhiteSpace(rabbitMqHost))
                throw new ArgumentNullException(nameof(rabbitMqHost), "RabbitMQ host configuration is missing.");

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("RabbitMQ credentials are missing in configuration.");

            services.AddMassTransit(config =>
            {
                config.SetKebabCaseEndpointNameFormatter();

                if (assembly != null)
                    config.AddConsumers(assembly);

                config.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(new Uri(rabbitMqHost), h =>
                    {
                        h.Username(username);
                        h.Password(password);
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

            return services;
        }
    }
}
