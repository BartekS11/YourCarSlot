using MediatR;

namespace YourCarSlot.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        public string Email { get;  set; }  = string.Empty;
    }
}