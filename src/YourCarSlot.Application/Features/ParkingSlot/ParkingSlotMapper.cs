using YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

namespace YourCarSlot.Application.Features.ParkingSlot;

internal static class ParkingSlotMapper
{
    internal static ParkingSlotDto Map(Domain.Entities.ParkingSlot parkingSlots)
    {
        return new()
        {
            Id = parkingSlots.Id,
            ParkingspotId = parkingSlots.ParkingspotId,
        };
    }
}
