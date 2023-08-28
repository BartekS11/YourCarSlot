using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot;
using YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;
using YourCarSlot.Application.Features.ParkingSlot.Queries.GetParkingSlot;

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
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<List<ParkingSlotDto>> Get()
        {
            var allParkingSlots = await _mediator.Send(new GetAllParkingSlotsQuery());
            return allParkingSlots;
        }

        [HttpGet]
        public async Task<ParkingSlotDto> Get(Guid id)
        {
            var parkingSlot = await _mediator.Send(new GetParkingSlotQuery(id));
            return parkingSlot;
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