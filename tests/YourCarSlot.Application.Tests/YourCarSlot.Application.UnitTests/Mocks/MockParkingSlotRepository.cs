using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.UnitTests.Mocks;

internal sealed class MockParkingSlotRepository
{
    private readonly static CancellationToken _cancellationToken = CancellationToken.None;

    internal static Mock<IParkingSlotRepository> GetAllParkingSlotsMockRepository()
    {
        var testGuid = Guid.Parse("4c750373-6309-40c8-af68-973aaf8da562");
        var parkingSlots = new ParkingSlot
        {
            Id = testGuid,
            ParkingspotId = 1
        };

        var mockRepo = new Mock<IParkingSlotRepository>();
        mockRepo.Setup(r => r.GetByIdAsync(testGuid, _cancellationToken))
            .ReturnsAsync(parkingSlots);

        mockRepo.Setup(r => r.CreateAsync(It.IsAny<ParkingSlot>(), _cancellationToken))
            .Returns((ParkingSlot parkingSlot) =>
            {
                return Task.CompletedTask;
            });

        return mockRepo;
    }
}