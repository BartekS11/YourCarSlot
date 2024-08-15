using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.User.Commands.UpdateUser;

public sealed class UpdateUser
{
    public sealed record Command(Guid Id, string PlateNumber, string Email, string Username) : IRequest<Unit>;

    internal sealed class UpdateUserCommandHandler : IRequestHandler<Command, Unit>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationToUpdate = UserMapper.Map(request);

            await _userRepository.UpdateAsync(reservationToUpdate, cancellationToken);

            return Unit.Value;
        }
    }

}
