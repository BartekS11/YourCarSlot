using AutoMapper;
using YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot;
using YourCarSlot.Application.Features.ParkingSlot.Queries.GetAllParkingSlots;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.MappingProfiles;

public sealed class ParkingSlotProfile : Profile
{
    public ParkingSlotProfile()
    {
        CreateMap<ParkingSlotDto, ParkingSlot>().ReverseMap();
        CreateMap<UpdateParkingSlotCommand, ParkingSlot>();
    }
}