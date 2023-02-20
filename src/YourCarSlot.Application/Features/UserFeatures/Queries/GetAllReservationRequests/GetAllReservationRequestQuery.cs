using MediatR;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests
{
    public record GetAllReservationRequestQuery : IRequest<List<ReservationRequestDto>>;
}