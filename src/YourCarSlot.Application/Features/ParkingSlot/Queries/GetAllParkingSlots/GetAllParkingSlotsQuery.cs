using MediatR;

namespace YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

public record GetAllParkingSlotsQuery : IRequest<List<ParkingSlotDto>>;