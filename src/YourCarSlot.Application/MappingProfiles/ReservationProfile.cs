using AutoMapper;
using YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;
using YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.MappingProfiles;

public sealed class ReservationProfile : Profile
{
    public ReservationProfile()
    {
        CreateMap<ReservationRequestDto, ReservationRequest>().ReverseMap();
        CreateMap<CreateReservationCommand, ReservationRequest>();
        CreateMap<UpdateReservationCommand, ReservationRequest>();
    }
}