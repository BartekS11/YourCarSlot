using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YourCarSlot.Infrastructure.DatabaseContext;


namespace YourCarSlot.Infrastructure
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<YCSDatabaseContext>(
                options => {
                    // options.
                }
            );

            return services;
        }   
    }
}