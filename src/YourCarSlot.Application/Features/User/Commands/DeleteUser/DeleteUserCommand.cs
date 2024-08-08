using MediatR;

namespace YourCarSlot.Application.Features.User.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}