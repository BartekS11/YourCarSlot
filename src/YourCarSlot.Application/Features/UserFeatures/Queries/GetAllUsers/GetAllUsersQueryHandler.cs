using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userrepository;
        private readonly IAppLogger<GetAllUsersQueryHandler> _logger;

        public GetAllUsersQueryHandler(IMapper mapper, IUserRepository userrepository, IAppLogger<GetAllUsersQueryHandler> logger)
        {
            this._mapper = mapper;
            this._userrepository = userrepository;
            this._logger = logger;
        }

        public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var userTypes = await _userrepository.GetAsync();

            if(userTypes == null)
            {
                throw new NotFoundException(nameof(userTypes));   
                _logger.LogWarning("Cannot find any user", nameof(userTypes));
            }
            var data = _mapper.Map<List<UserDto>>(userTypes);

            return data;
        }
    }
}