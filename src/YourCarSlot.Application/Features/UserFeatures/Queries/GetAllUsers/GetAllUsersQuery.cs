using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public record GetAllUsersQuery : IRequest<List<UserDto>>;

}