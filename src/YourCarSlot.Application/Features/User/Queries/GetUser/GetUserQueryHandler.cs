using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;

namespace YourCarSlot.Application.Features.User.Queries.GetUser;

public sealed class GetUserHandler
{
    public sealed record Command(Guid Id) : IRequest<UserDto>;

    internal sealed class Handler : IRequestHandler<Command, UserDto>
    {
        private readonly IUserRepository _userRepository;

        public Handler(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(Command request, CancellationToken cancellationToken)
        {
            var userType = await _userRepository.GetByIdAsync(request.Id, cancellationToken) 
                ?? throw new NotFoundException("User not found", request.Id);

            var data = UserMapper.Map(userType);

            return data;
        }
    }

}


