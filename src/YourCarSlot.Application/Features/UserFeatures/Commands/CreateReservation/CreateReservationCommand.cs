using MediatR;
using YourCarSlot.Domain.Entities;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation
{
    public class CreateReservationCommand : IRequest<Guid>
    {
        public PartOfTheDay PartOfTheDayReservation { get; protected set; }
        public DateTime BookingRequestTime { get; protected set; }
        public User UserRequesting { get; protected set; }
        public ParkingList ParkingListRequesting { get; protected set; }
        public int ParkingSlotRequesting { get; protected set; }
    }
}