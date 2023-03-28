using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;
using YourCarSlot.Application.Features.Vehicle.Commands.DeleteVehicle;
using YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;
using YourCarSlot.Application.Features.Vehicle.Queries.GetAllVehicles;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<VehicleDto>> Get()
        {
            var getAllVehiclesQuery = new GetAllVehiclesQuery();
            var allVehicles = await _mediator.Send(getAllVehiclesQuery);
            return allVehicles;
        }

        [HttpGet("{id}")]
        public async Task<VehicleDto> Get(Guid id)
        {
            var getVehicleQuery = new GetVehicleQuery(id);
            var Vehicle = await _mediator.Send(getVehicleQuery);
            return Vehicle;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post(CreateVehicleCommand createVehicleCommand)
        {
            var response = await _mediator.Send(createVehicleCommand);
            return CreatedAtAction(nameof(Get), new { id = response});
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateVehicleCommand updateVehicleCommand)
        {
            await _mediator.Send(updateVehicleCommand);

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string plateNumber)
        {
            var command = new DeleteVehicleCommand { PlateNumber = plateNumber };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}