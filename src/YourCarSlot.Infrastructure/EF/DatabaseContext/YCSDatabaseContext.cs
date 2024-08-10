using Microsoft.EntityFrameworkCore;
using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.EF.DatabaseContext;

public sealed class YCSDatabaseContext : DbContext
{
    public YCSDatabaseContext(DbContextOptions<YCSDatabaseContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<ReservationRequest> ReservationRequest { get; set; }
    public DbSet<ParkingSlot> ParkingSlot { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(YCSDatabaseContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach(var entry in ChangeTracker.Entries<BaseEntity>()
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
