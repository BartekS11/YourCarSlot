using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.User.Queries.GetAllUsers;

public sealed class GetAllUsersHandler
{
    public sealed record Command : IRequest<List<UserDto>>;

    internal sealed class Handler : IRequestHandler<Command, List<UserDto>>
    {
        private readonly IUserRepository _userrepository;

        public Handler(IUserRepository userrepository)
        {
            _userrepository = userrepository;
        }

        public async Task<List<UserDto>> Handle(Command request, CancellationToken cancellationToken)
        {
            var userTypes = await _userrepository.GetAsync(cancellationToken) 
                ?? throw new NotFoundException("Cannot get all users");

            var data = new List<UserDto>();
            
            foreach(var user in userTypes)
            {
                var item = UserMapper.Map(user);
                data.Add(item);
            }

            return data;
        }
    }
}
