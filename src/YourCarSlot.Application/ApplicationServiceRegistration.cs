using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application
{
    public static class ApplicationServiceRegistration
    {
        //Registering services
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            return services;
        }
    }
}