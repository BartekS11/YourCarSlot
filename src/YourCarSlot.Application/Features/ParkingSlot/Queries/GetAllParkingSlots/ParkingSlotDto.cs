namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

public sealed class ParkingSlotDto
{
    public Guid Id { get; init; } = default!;
    public int? ParkingspotId { get; init; } = default!;
}