using YourCarSlot.Application.Features.User.Commands.CreateUser;
using YourCarSlot.Application.Features.User.Commands.UpdateUser;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;

namespace YourCarSlot.Application.Features.User;

internal static class UserMapper
{

    internal static UserDto Map(Domain.Entities.User user)
        => new()
        {
            Id = user.Id,
            Email = user.Email,
            PlateNumber = user.PlateNumber,
            Username = user.Username
        };

    internal static Domain.Entities.User Map(CreateUser.Command createUserCommand)
        => new()
        {
            Email = createUserCommand.Email,
            Password = createUserCommand.Password,
            Username = createUserCommand.Username,
            PlateNumber = createUserCommand.PlateNumber,
        };

    internal static Domain.Entities.User Map(UpdateUser.Command updateUserCommand)
        => new()
        {
            Id = updateUserCommand.Id,
            PlateNumber = updateUserCommand.PlateNumber,
            Email = updateUserCommand.Email,
            Username = updateUserCommand.Username
        };

}
