using MediatR;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public record GetAllUsersQuery : IRequest<List<UserDto>>;

}