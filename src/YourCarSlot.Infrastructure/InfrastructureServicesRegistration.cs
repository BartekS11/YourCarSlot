using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Application.Contracts.Logging;
using YourCarSlot.Infrastructure.DatabaseContext;
using YourCarSlot.Infrastructure.Logging;

namespace YourCarSlot.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));           
            
            return services;
        }   
    }
}