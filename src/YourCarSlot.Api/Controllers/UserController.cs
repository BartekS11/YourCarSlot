using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourCarSlot.Application.Features.User.Commands.CreateUser;
using YourCarSlot.Application.Features.User.Commands.DeleteUser;
using YourCarSlot.Application.Features.User.Commands.UpdateUser;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;
using YourCarSlot.Application.Features.User.Queries.GetUser;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<UserDto> Get(Guid id)
        {
            var getUserQuery = new GetUserQuery(id);
            var usersType = await _mediator.Send(getUserQuery);

            return usersType;
        }

        [HttpGet]
        public async Task<List<UserDto>> Get()
        {
            var getAllUserQuery = new GetAllUsersQuery();
            var allUsersType = await _mediator.Send(getAllUserQuery);

            return allUsersType;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post(CreateUserCommand userType)
        {
            var response = await _mediator.Send(userType);
            return CreatedAtAction(nameof(Get), new { id = response} );
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteUserCommand { Id = id };

            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateUserCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}