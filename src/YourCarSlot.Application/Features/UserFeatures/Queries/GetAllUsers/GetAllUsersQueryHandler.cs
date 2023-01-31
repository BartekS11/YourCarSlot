using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Logging;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userrepository;
        private readonly IAppLogger<GetAllUsersQueryHandler> _logger;

        public GetAllUsersQueryHandler(IMapper mapper, IUserRepository userrepository,
            IAppLogger<GetAllUsersQueryHandler> logger)
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
            }
            var data = _mapper.Map<List<UserDto>>(userTypes);
            _logger.LogInformation("All user type were retrieved successfully");

            return data;
        }
    }
}