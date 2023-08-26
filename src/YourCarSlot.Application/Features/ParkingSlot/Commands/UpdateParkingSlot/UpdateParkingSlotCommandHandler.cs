using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.ParkingSlot.Commands.UpdateParkingSlot
{
    public class UpdateParkingSlotCommandHandler : IRequestHandler<UpdateParkingSlotCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IParkingSlotRepository _parkingSlotRepository;

        public UpdateParkingSlotCommandHandler(IMapper mapper, IParkingSlotRepository parkingSlotRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _parkingSlotRepository = parkingSlotRepository ?? throw new ArgumentNullException(nameof(parkingSlotRepository));
        }

        public async Task<Unit> Handle(UpdateParkingSlotCommand request, CancellationToken cancellationToken)
        {
            var parkingSlotToUpdate = _mapper.Map<Domain.Entities.ParkingSlot>(request);

            await _parkingSlotRepository.UpdateAsync(parkingSlotToUpdate);

            return Unit.Value;
        }
    }
}