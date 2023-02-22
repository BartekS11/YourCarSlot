using AutoMapper;
using YourCarSlot.Application.Features.Vehicle.Commands.CreateVehicle;
using YourCarSlot.Application.Features.Vehicle.Commands.UpdateVehicle;
using YourCarSlot.Application.Features.Vehicle.Queries.GetVehicle;
using YourCarSlot.Domain.Entities;

namespace YourCarSlot.Application.MappingProfiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            CreateMap<VehicleDto, Vehicle>().ReverseMap();
            CreateMap<CreateVehicleCommand, Vehicle>();
            CreateMap<UpdateVehicleCommand, Vehicle>();
        }
    }
}