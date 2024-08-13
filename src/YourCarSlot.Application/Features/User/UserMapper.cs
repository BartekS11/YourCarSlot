using YourCarSlot.Application.Features.User.Commands.CreateUser;
using YourCarSlot.Application.Features.User.Commands.UpdateUser;

namespace YourCarSlot.Application.Features.User;

internal static class UserMapper
{
    internal static Domain.Entities.User Map(CreateUser.Command createUserCommand)
    {
        return new()
        {
            Email = createUserCommand.Email,
            Password = createUserCommand.Password,
            Username = createUserCommand.Username,
            PlateNumber = createUserCommand.PlateNumber,
        };
    }

    internal static Domain.Entities.User Map(UpdateUser.Command updateUserCommand)
    {
        return new()
        {
            Id = updateUserCommand.Id,
            PlateNumber = updateUserCommand.PlateNumber,
            Email = updateUserCommand.Email,
            Username = updateUserCommand.Username
        };
    }
}
