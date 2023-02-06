using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Infrastructure.EF.DatabaseContext;
using YourCarSlot.Infrastructure.Repository;

namespace YourCarSlot.Infrastructure
{
    public static class InfrastructureServiceRegistrations
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<YCSDatabaseContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionStrings:DefaultConnections"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IParkingSlotRepository, ParkingSlotRepository>();
            services.AddScoped<IReservationRequestRepository, ReservationRequestRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();

            return services;
        }
    }
}