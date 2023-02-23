using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.UnitTests.Mocks
{
    public class MockReservationRequestRepository
    {
        public static Mock<IReservationRequestRepository> GetAllReservationRequestMockRepository()
        {
            var stringGuid = "81a130d2-502f-4cf1-a376-63edeb000e9f";
            var stringGuid1 = "34a130d2-502f-4cf1-a376-63edeb092137";
            var userrequestingExample = "36b99c90-b13d-11ed-afa1-0242ac120002";
            var userrequestingExample1 = "4428bf00-b13d-11ed-afa1-0242ac120002";
            var reservationReuests = new List<ReservationRequest>
            {
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
                // new ReservationRequest(DateTime.Now, Guid.Parse(stringGuid1), 0, 4)
            };

            var mockRepo = new Mock<IReservationRequestRepository>();
            mockRepo.Setup(r => r.GetAsync()).ReturnsAsync(reservationReuests);

            mockRepo.Setup(r => r.CreateAsync(It.IsAny<ReservationRequest>()))
                .Returns((ReservationRequest reservationRequest) => {
                    reservationReuests.Add(reservationRequest);
                    return Task.CompletedTask;
                });

            return mockRepo;
        }
    }
}