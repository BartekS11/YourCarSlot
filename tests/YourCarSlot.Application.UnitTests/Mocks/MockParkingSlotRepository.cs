using Moq;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.UnitTests.Mocks
{
    public class MockParkingSlotRepository
    {
        public static Mock<IParkingSlotRepository> GetAllParkignSlotsMockRepository()
        {
            var guid1 = "4c750373-6309-40c8-af68-973aaf8da562";
            var parkingSlots = new ParkingSlot
                {
                   Id = Guid.Parse(guid1),
                   ParkingspotId = 1
                };
            
            var mockRepo = new Mock<IParkingSlotRepository>();
            mockRepo.Setup(r => r.GetByIdAsync(Guid.Parse(guid1))).ReturnsAsync(parkingSlots);
            mockRepo.Setup(r => r.CreateAsync(It.IsAny<ParkingSlot>()))
                .Returns((ParkingSlot parkingSlot)=> 
                {
                    return Task.CompletedTask;
                });
            return mockRepo;   
        }
    }
}