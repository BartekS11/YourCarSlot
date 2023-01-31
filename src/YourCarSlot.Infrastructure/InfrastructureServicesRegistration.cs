using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Application.Contracts.Logging;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Infrastructure.DatabaseContext;
using YourCarSlot.Infrastructure.Logging;
using YourCarSlot.Infrastructure.Repository;

namespace YourCarSlot.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));           

            services.AddScoped<IParkingListRepository, ParkingListRepository>();            
            
            services.AddScoped<IUserRepository, UserRepository>();            

            services.AddScoped<IReservationRequestRepository, ReservationRequestRepository>();            

            return services;
        }   
    }
}