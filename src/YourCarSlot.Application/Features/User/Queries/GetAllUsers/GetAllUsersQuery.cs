using MediatR;

namespace YourCarSlot.Application.Features.User.Queries.GetAllUsers;

public record GetAllUsersQuery : IRequest<List<UserDto>>;