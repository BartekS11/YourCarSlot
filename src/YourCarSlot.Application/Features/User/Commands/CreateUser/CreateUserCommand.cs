using MediatR;

namespace YourCarSlot.Application.Features.User.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string Email { get;  set; }  = string.Empty;
        public string Password { get;  set; }  = string.Empty;
        public string Username { get;  set; }  = string.Empty;
        public string PlateNumber { get; set; }  = string.Empty;
    }
}