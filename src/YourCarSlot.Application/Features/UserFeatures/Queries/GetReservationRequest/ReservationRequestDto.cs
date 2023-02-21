namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest
{
    public class ReservationRequestDto
    {
        public Guid? Id { get; set; }
        public int ParkingSlotRequesting { get; set; }
        public bool Reserved { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        public Guid? UserRequestingId { get; set; }
        public DateTime? CreatedAt { get;  set; }
        public DateTime? DateModified { get;  set; }
    }
}