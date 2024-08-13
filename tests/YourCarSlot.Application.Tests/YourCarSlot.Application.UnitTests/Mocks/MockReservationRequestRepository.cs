using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.UnitTests.Mocks;

internal sealed class MockReservationRequestRepository
{
    private readonly static CancellationToken _cancellationToken = CancellationToken.None;
    internal static Mock<IReservationRequestRepository> GetAllReservationRequestMockRepository()
    {
        var stringGuid = Guid.Parse("81a130d2-502f-4cf1-a376-63edeb000e9f");
        var stringGuid1 = Guid.Parse("34a130d2-502f-4cf1-a376-63edeb092137");
        var userrequestingExample = Guid.Parse("36b99c90-b13d-11ed-afa1-0242ac120002");
        var userrequestingExample1 = Guid.Parse("4428bf00-b13d-11ed-afa1-0242ac120002");
        var reservationReuests = new List<ReservationRequest>
        {
            new() {
                Id = stringGuid,
                BookingRequestTime = DateTime.UtcNow,
                Reserved = true,
                PlateNumber = "23233-33",
                UserRequestingId = userrequestingExample,
                CreatedAt = DateTime.Now,
                DateModified = DateTime.Now
            },
            new() {
                Id = stringGuid1,
                BookingRequestTime = DateTime.UtcNow,
                Reserved = true,
                PlateNumber = "44312413433-33",
                UserRequestingId = userrequestingExample1,
                CreatedAt = DateTime.Now,
                DateModified = DateTime.Now
            }
        };

        var mockRepo = new Mock<IReservationRequestRepository>();
        mockRepo.Setup(r => r.GetAsync(_cancellationToken))
            .ReturnsAsync(reservationReuests);

        // mockRepo.Setup(r => r.CreateAsync(It.IsAny<ReservationRequest>(), _cancellationToken))
        //     .Returns((ReservationRequest reservationRequest) => {
        //         reservationReuests.Add(reservationRequest);
                
        //         return Task.CompletedTask;
        //     });

        return mockRepo;
    }

    internal static Mock<IReservationRequestRepository> GetReservationRequestMockRepository()
    {
        var sampleId = Guid.Parse("4c750373-6309-40c8-af68-973aaf8da562");
        var userrequestingExample = Guid.Parse("36b99c90-b13d-11ed-afa1-0242ac120002");
        var reservationReuests = new ReservationRequest
            {
                Id = sampleId,
                BookingRequestTime = DateTime.UtcNow,
                Reserved = true,
                PlateNumber = "23233-33",
                UserRequestingId = userrequestingExample,
                CreatedAt = DateTime.Now,
                DateModified = DateTime.Now
            };
        var mockRepo = new Mock<IReservationRequestRepository>();
        mockRepo.Setup(r => r.GetByIdAsync(sampleId, _cancellationToken))
            .ReturnsAsync(reservationReuests);

        return mockRepo;
    }
}
