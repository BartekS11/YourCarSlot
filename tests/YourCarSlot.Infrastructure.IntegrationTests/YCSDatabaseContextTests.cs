using Microsoft.EntityFrameworkCore;
using Shouldly;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.IntegrationTests
{
    public class YCSDatabaseContextTests
    {
        private  YCSDatabaseContext _ycsDatabaseContext;

        public YCSDatabaseContextTests()
        {
            var dbOptions = new DbContextOptionsBuilder<YCSDatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _ycsDatabaseContext = new YCSDatabaseContext(dbOptions);
        }

        [Fact]
        public async void SaveSetDateCreatedValue()
        {
            var stringGuid = "81a130d2-502f-4cf1-a376-63edeb000e9f";
            var userrequestingExample = "36b99c90-b13d-11ed-afa1-0242ac120002";
            var reservationRequest = new ReservationRequest
                {
                    Id = Guid.Parse(stringGuid),
                    BookingRequestTime = DateTime.UtcNow,
                    Reserved = true,
                    PlateNumber = "23233-33",
                    UserRequestingId = Guid.Parse(userrequestingExample),
                    CreatedAt = DateTime.Now,
                    DateModified = DateTime.Now
                };

            await _ycsDatabaseContext.ReservationRequest.AddAsync(reservationRequest);
            await _ycsDatabaseContext.SaveChangesAsync();

            reservationRequest.CreatedAt.ShouldNotBeNull();
        }

        [Fact]
        public async void SaveSetDateModifiedValue()
        {
            var stringGuid = "81a130d2-502f-4cf1-a376-63edeb000e9f";
            var userrequestingExample = "36b99c90-b13d-11ed-afa1-0242ac120002";
            var reservationRequest = new ReservationRequest
                {
                    Id = Guid.Parse(stringGuid),
                    BookingRequestTime = DateTime.UtcNow,
                    Reserved = true,
                    PlateNumber = "23233-33",
                    UserRequestingId = Guid.Parse(userrequestingExample),
                    CreatedAt = DateTime.Now,
                    DateModified = DateTime.Now
                };

            await _ycsDatabaseContext.ReservationRequest.AddAsync(reservationRequest);
            await _ycsDatabaseContext.SaveChangesAsync();

            reservationRequest.DateModified.ShouldNotBeNull();
        }
    }
}