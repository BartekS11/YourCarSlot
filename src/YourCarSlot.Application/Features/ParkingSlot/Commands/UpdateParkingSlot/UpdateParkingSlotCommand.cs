using MediatR;

namespace YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot
{
    public class UpdateParkingSlotCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public int? ParkingspotId { get; set; }   
    }
}