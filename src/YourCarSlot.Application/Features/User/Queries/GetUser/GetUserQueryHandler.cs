using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;

namespace YourCarSlot.Application.Features.User.Queries.GetUser;

public sealed class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserQueryHandler(IMapper mapper, IUserRepository userRepository) 
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var userType = await _userRepository.GetByIdAsync(request.Id, cancellationToken) 
            ?? throw new NotFoundException("User not found", request.Id);


        var data = _mapper.Map<UserDto>(userType);

        return data;
    }
}
