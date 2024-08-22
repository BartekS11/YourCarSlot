using MediatR;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;
using YourCarSlot.Application.Features.UserFeatures.Commands.DeleteReservation;
using YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

namespace YourCarSlot.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
// [Authorize]
public sealed class ReservationRequestController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReservationRequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ReservationRequestDto[]> Get(CancellationToken cancellationToken)
    {
        var query = new GetAllReservationRequestQuery.Command();
        var allReservationRequest = await _mediator.Send(query, cancellationToken);
        return allReservationRequest;
    }

    [HttpGet("{id}")]
    public async Task<ReservationRequestDto> Get(Guid id, CancellationToken cancellationToken)
    {
        var query = new ReservationRequestQuery.Command(id);
        var reservationRequest = await _mediator.Send(query, cancellationToken);
        return reservationRequest;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]  
    public async Task<ActionResult> Post(CreateReservationHandler.Command reservationType, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(reservationType, cancellationToken);
        return CreatedAtAction(nameof(Post), new { id = response });
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Put(UpdateReservationHandler.Command reservationType, CancellationToken cancellationToken)
    {
        await _mediator.Send(reservationType, cancellationToken);
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var command = new DeleteReservationHandler.Command(id);

        await _mediator.Send(command, cancellationToken);
        return NoContent();
    }
}
