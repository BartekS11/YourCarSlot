using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationRequestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationRequestController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ReservationRequestDto> Get(Guid id)
        {
            var reservationRequest = await _mediator.Send(new ReservationRequestQuery(id));
            return reservationRequest;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete]
        public void Delete(int id)
        {
            
        }
    }
}