using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest
{
    public record ReservationRequestQuery(Guid Id) : IRequest<ReservationRequestDto>;
}