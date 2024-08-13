using YourCarSlot.Application.Features.User.Commands.CreateUser;

namespace YourCarSlot.Application.Features.User;

internal static class UserMapper
{
    internal static Domain.Entities.User Map(CreateUserCommand createUserCommand)
    {
        return new()
        {
            Email = createUserCommand.Email,
            Password = createUserCommand.Password,
            Username = createUserCommand.Username,
            PlateNumber = createUserCommand.PlateNumber,
        };
    }
}