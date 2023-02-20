using MediatR;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest
{
    public record ReservationRequestQuery(Guid Id) : IRequest<ReservationRequestDto>;
}