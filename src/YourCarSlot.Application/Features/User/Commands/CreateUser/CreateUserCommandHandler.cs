using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.User.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IAppLogger<CreateUserCommandHandler> _logger;

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository, IAppLogger<CreateUserCommandHandler> logger)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateUserCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                _logger.LogWarning("Invalid email while creating user");
                throw new BadRequestException("Invalid email");
            }

            var userToCreate = _mapper.Map<Domain.Entities.User>(request);
            await _userRepository.CreateAsync(userToCreate);

            _logger.LogInformation("User added successfuly");
            return userToCreate.Id;
        }
    }
}