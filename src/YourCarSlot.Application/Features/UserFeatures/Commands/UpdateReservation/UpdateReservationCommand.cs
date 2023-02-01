using MediatR;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Domain.ValueObjects;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation
{
    public class UpdateReservationCommand : IRequest<Unit>
    {
        public Guid Id { get; protected set; }
        public ParkingSlots ParkingSlotRequesting { get; protected set; }
        public User UserRequesting { get; protected set; }
        public PartOfTheDay PartOfTheDayReservation { get; protected set; }
        public DateTime BookingRequestTime { get; protected set; }
    }
}