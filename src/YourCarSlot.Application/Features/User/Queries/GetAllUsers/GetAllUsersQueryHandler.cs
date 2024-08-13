using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

namespace YourCarSlot.Application.Features.User.Queries.GetAllUsers;

public sealed class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userrepository;

    public GetAllUsersQueryHandler(IMapper mapper, IUserRepository userrepository)
    {
        _mapper = mapper;
        _userrepository = userrepository;
    }

    public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var userTypes = await _userrepository.GetAsync(cancellationToken) 
            ?? throw new NotFoundException("Cannot get all users");
        
        var data = _mapper.Map<List<UserDto>>(userTypes);

        return data;
    }
}