using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.EF.Configuration
{
    public class ParkingSlotConfiguration : IEntityTypeConfiguration<ParkingSlot>
    {
        public void Configure(EntityTypeBuilder<ParkingSlot> builder)
        {
            var guid1 = "4c750373-6309-40c8-af68-973aaf8da562";
            builder.HasData(
                new ParkingSlot
                {
                   Id = Guid.Parse(guid1),
                   ParkingspotId = 1
                }
            );
        }
    }
}