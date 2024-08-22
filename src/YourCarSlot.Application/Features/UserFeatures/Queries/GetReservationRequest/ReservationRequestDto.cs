namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

public sealed class ReservationRequestDto
{
    public Guid? Id { get; init; }
    public int? ParkingSlotRequesting { get; init; }
    public bool Reserved { get; init; }
    public string PlateNumber { get; init; } = string.Empty;
    public Guid? UserRequestingId { get; init; }
    public DateTime? CreatedAt { get; init; }
    public DateTime? DateModified { get; init; }
}