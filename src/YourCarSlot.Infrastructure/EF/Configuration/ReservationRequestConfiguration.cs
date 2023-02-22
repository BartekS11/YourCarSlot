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
            var stringGuid1 = "34a130d2-502f-4cf1-a376-63edeb092137";
            var userrequestingExample = "36b99c90-b13d-11ed-afa1-0242ac120002";
            var userrequestingExample1 = "4428bf00-b13d-11ed-afa1-0242ac120002";
            builder.HasData(
                new ReservationRequest
                {
                    Id = Guid.Parse(stringGuid),
                    BookingRequestTime = DateTime.UtcNow,
                    Reserved = true,
                    PlateNumber = "23233-33",
                    UserRequestingId = Guid.Parse(userrequestingExample),
                    CreatedAt = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new ReservationRequest
                {
                    Id = Guid.Parse(stringGuid1),
                    BookingRequestTime = DateTime.UtcNow,
                    Reserved = true,
                    PlateNumber = "44312413433-33",
                    UserRequestingId = Guid.Parse(userrequestingExample1),
                    CreatedAt = DateTime.Now,
                    DateModified = DateTime.Now
                }
            );
        }
    }
}