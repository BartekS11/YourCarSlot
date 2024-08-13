using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Application.Behaviors;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application;

public static class ApplicationServiceRegistration
{
    //Registering application services
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddApplicationValidators();
        services.AddMediatR(cfg => 
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddOpenBehavior(typeof(LoggingBehavior<, >));
            cfg.AddOpenBehavior(typeof(ValidationBehavior<, >));
        });

        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

        return services;
    }

    internal static IServiceCollection AddApplicationValidators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        
        return services;
    }
}