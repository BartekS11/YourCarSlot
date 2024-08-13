using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;
using YourCarSlot.Application.Features.Vehicle.Commands.DeleteVehicle;
using YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;
using YourCarSlot.Application.Features.Vehicle.Queries.GetAllVehicles;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;

namespace YourCarSlot.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public sealed class VehicleController : ControllerBase
{
    private readonly IMediator _mediator;

    public VehicleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<VehicleDto>> Get(CancellationToken cancellationToken)
    {
        var query = new GetAllVehiclesQuery();
        var allVehicles = await _mediator.Send(query, cancellationToken);

        return allVehicles;
    }

    [HttpGet("{id}")]
    public async Task<VehicleDto> Get(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetVehicleQuery(id);
        var Vehicle = await _mediator.Send(query, cancellationToken);

        return Vehicle;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(CreateVehicleCommand createVehicleCommand, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(createVehicleCommand, cancellationToken);
        return CreatedAtAction(nameof(Get), new { id = response});
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Put(UpdateVehicleCommand updateVehicleCommand, CancellationToken cancellationToken)
    {
        await _mediator.Send(updateVehicleCommand, cancellationToken);

        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(string plateNumber, CancellationToken cancellationToken)
    {
        var command = new DeleteVehicleCommand { PlateNumber = plateNumber };
        await _mediator.Send(command, cancellationToken);

        return NoContent();
    }
}