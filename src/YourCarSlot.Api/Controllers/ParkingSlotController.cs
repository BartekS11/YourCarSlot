using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot;
using YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ParkingSlotController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ParkingSlotController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ParkingSlotDto>> Get()
        {
            var getAllParkingSlotsQuery = new GetAllParkingSlotsQuery();
            var allParkingSlots = await _mediator.Send(getAllParkingSlotsQuery);
            return allParkingSlots;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateParkingSlotCommand updateParkingSlotCommand)
        {
            await _mediator.Send(updateParkingSlotCommand);

            return NoContent();
        }

    }
}