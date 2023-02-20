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
        public Guid UserRequestingId { get; set; }
        public int ParkingSlotRequesting { get; set; }
        public string PlateNumber { get; set; }
    }
}