using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var reservationToUpdate = _mapper.Map<Domain.Entities.User>(request);

            await _userRepository.UpdateAsync(reservationToUpdate);

            return Unit.Value;    
        }
    }
}