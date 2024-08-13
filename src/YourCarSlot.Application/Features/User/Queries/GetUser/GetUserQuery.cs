using MediatR;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;

namespace YourCarSlot.Application.Features.User.Queries.GetUser;

public record GetUserQuery(Guid Id) : IRequest<UserDto>;