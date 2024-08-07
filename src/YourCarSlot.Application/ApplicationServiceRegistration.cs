using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Application.Behaviors;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application;

public static class ApplicationServiceRegistration
{
    //Registering application services
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => 
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));
        });

        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        return services;
    }
}