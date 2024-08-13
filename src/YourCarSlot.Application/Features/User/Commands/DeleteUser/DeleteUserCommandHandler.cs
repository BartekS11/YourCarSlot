using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.User.Commands.DeleteUser;

public sealed class DeleteUserCommand
{
    public sealed record Command(Guid ID) : IRequest<Unit>;

    public sealed class Handler : IRequestHandler<Command, Unit>
    {
        private readonly IUserRepository _userRepository;

        public Handler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var userToDelete = await _userRepository.GetByIdAsync(request.ID, cancellationToken);

            await _userRepository.DeleteAsync(userToDelete!, cancellationToken);            

            return Unit.Value;
        }
    }
}
