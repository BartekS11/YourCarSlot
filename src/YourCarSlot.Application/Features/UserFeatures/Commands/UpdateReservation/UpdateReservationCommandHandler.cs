using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public UpdateReservationCommandHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository)
        {
            this._mapper = mapper;
            this._reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<Unit> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservationToUpdate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

            await _reservationRequestRepository.UpdateAsync(reservationToUpdate);

            return Unit.Value;    
        }
    }
}