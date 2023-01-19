using AutoMapper;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}