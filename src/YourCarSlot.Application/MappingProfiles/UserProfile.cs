using AutoMapper;
using YourCarSlot.Application.Features.User.Commands.CreateUser;
using YourCarSlot.Application.Features.User.Commands.UpdateUser;
using YourCarSlot.Application.Features.User.Queries.GetAllUsers;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.MappingProfiles;

public sealed class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
        CreateMap<CreateUserCommand, User>();
        CreateMap<UpdateUserCommand, User>();
    }
}