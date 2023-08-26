using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;
using YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;
using YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class ReservationRequestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationRequestController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ReservationRequestDto>> Get()
        {
            var allReservationRequest = await _mediator.Send(new GetAllReservationRequestQuery());
            return allReservationRequest;
        }

        [HttpGet("{id}")]
        public async Task<ReservationRequestDto> Get(Guid id)
        {
            var reservationRequest = await _mediator.Send(new ReservationRequestQuery(id));
            return reservationRequest;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post(CreateReservationCommand reservationType)
        {
            var response = await _mediator.Send(reservationType);
            return CreatedAtAction(nameof(Get), new { id = response});
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateReservationCommand reservationType)
        {
            await _mediator.Send(reservationType);
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteReservationCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}