using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest
{
    public class ReservationRequestDto
    {
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? DateModified { get; protected set; }
    }
}