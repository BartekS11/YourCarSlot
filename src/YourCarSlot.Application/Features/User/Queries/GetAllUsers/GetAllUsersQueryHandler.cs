using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userrepository;
        private readonly IAppLogger<GetAllUsersQueryHandler> _logger;

        public GetAllUsersQueryHandler(IMapper mapper, IUserRepository userrepository, IAppLogger<GetAllUsersQueryHandler> logger)
        {
            _mapper = mapper;
            _userrepository = userrepository;
            _logger = logger;
        }

        public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var userTypes = await _userrepository.GetAsync(cancellationToken);

            if(userTypes == null)
            {
                _logger.LogWarning("Cannot find any user", nameof(userTypes));

                throw new NotFoundException(nameof(userTypes));   
            }
            var data = _mapper.Map<List<UserDto>>(userTypes);
            _logger.LogInformation("All users request were retrieved successfuly");

            return data;
        }
    }
}