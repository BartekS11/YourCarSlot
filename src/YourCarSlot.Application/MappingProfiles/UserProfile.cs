using AutoMapper;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetAllUsers;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
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