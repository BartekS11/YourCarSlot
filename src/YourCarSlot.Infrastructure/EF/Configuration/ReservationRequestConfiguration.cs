using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Infrastructure.EF.Configuration
{
    public class ReservationRequestConfiguration : IEntityTypeConfiguration<ReservationRequest>
    {
        
        public void Configure(EntityTypeBuilder<ReservationRequest> builder)
        {
            var stringGuid = "81a130d2-502f-4cf1-a376-63edeb000e9f";
            var userrequestingExample = "25a130d2-502f-4cf1-a376-63edeb027212";
            builder.HasData(
                new ReservationRequest
                {
                    Id = Guid.Parse(stringGuid),
                    BookingRequestTime = DateTime.UtcNow,
                    ParkingSlotRequesting = 4,
                    Reserved = false,
                    UserRequestingId = Guid.Parse(userrequestingExample),
                    PlateNumber = "4324-1345-53",
                    CreatedAt = DateTime.Now,
                    DateModified = DateTime.Now
                }
            );
        }
    }
}