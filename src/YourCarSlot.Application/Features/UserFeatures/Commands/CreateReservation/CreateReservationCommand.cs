using MediatR;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Domain.ValueObjects;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation
{
    public class CreateReservationCommand : IRequest<Guid>
    {
        public PartOfTheDay PartOfTheDayReservation { get; set; }
        public DateTime BookingRequestTime { get; set; }
        public User UserRequesting { get; set; }
        public ParkingList ParkingListRequesting { get; set; }
        public ParkingSlots ParkingSlotRequesting { get; set; }
    }
}