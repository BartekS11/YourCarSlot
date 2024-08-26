using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.User.Commands.CreateUser;
using YourCarSlot.Application.Features.User.Commands.DeleteUser;
using YourCarSlot.Application.Features.User.Commands.UpdateUser;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;
using YourCarSlot.Application.Features.User.Queries.GetUser;

namespace YourCarSlot.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
[ResponseCache(Duration = 60)]
public sealed class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<UserDto> Get(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetUserHandler.Command(id);
        var usersType = await _mediator.Send(query, cancellationToken);

        return usersType;
    }

    [HttpGet]
    public async Task<List<UserDto>> Get(CancellationToken cancellationToken)
    {
        var query = new GetAllUsersHandler.Command();
        var allUsersType = await _mediator.Send(query, cancellationToken);

        return allUsersType;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(CreateUser.Command userType, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(userType, cancellationToken);
        return CreatedAtAction(nameof(Post), new { id = response });
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var command = new DeleteUser.Command(id);

        await _mediator.Send(command, cancellationToken);
        return NoContent();
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Put(UpdateUser.Command command, CancellationToken cancellationToken)
    {
        await _mediator.Send(command, cancellationToken);
        return NoContent();
    }
}