using MediatR;

namespace YourCarSlot.Application.Features.User.Commands.CreateUser;

public sealed class CreateUserCommand : IRequest<Guid>
{
    public string Email { get; init; }  = string.Empty;
    public string Password { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public string PlateNumber { get; init; } = string.Empty;
}