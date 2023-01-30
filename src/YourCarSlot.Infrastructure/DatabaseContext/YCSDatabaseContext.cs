using Microsoft.EntityFrameworkCore;
using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.DatabaseContext
{
    public class YCSDatabaseContext : DbContext
    {
        public YCSDatabaseContext(DbContextOptions<YCSDatabaseContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ReservationRequest> ReservationRequests { get; set; }
        public DbSet<ParkingList> ParkingLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(YCSDatabaseContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in base.ChangeTracker.Entries<BaseEntity>()
                    .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.DateModified = DateTime.Now; 
                
                if(entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}