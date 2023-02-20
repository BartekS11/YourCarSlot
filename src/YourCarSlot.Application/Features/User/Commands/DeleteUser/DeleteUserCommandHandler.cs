using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.User.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = await _userRepository.GetByIdAsync(request.Id);

            await _userRepository.DeleteAsync(userToDelete);            

            return Unit.Value;
        }
    }
}