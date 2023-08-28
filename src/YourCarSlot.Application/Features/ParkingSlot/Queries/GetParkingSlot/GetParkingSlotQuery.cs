using MediatR;
using YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetParkingSlot
{
    public record GetParkingSlotQuery(Guid Id): IRequest<ParkingSlotDto> {}
}
