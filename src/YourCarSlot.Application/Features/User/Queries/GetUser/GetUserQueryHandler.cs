using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Features.User.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IAppLogger<GetUserQueryHandler> _logger;

        public GetUserQueryHandler(IMapper mapper, IUserRepository userRepository, IAppLogger<GetUserQueryHandler> logger)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
            this._logger = logger;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var userType = await _userRepository.GetByIdAsync(request.Id);

            if(userType == null)
            {
                throw new NotFoundException(nameof(userType), request.Id);
            }

            var data = _mapper.Map<UserDto>(userType);
            _logger.LogInformation("User request were retrieved successfuly");

            return data;
        }
    }
}