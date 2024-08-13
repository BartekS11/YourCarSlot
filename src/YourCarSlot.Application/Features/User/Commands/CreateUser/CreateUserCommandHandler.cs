using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.User.Commands.CreateUser;

public sealed class CreateUser
{
    public sealed record Command(string Email, string Password, string Username, string PlateNumber) : IRequest<Guid>;

    internal sealed class Handler : IRequestHandler<Command, Guid>
    {
        private readonly IUserRepository _userRepository;

        public Handler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
        {
            var userToCreate = UserMapper.Map(request);
            await _userRepository.CreateAsync(userToCreate, cancellationToken);

            return userToCreate.Id;
        }
    }
}
