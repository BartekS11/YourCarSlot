using MediatR;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Domain.ValueObjects;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation
{
    public class UpdateReservationCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public int ParkingSlotRequesting { get; set; }
        public Guid UserRequestingId { get; set; }
        public PartOfTheDay PartOfTheDayReservation { get; set; }
        public DateTime BookingRequestTime { get; set; }
        public string PlateNumber { get; set; }
    }
}