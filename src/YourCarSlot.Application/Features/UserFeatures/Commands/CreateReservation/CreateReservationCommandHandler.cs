using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public CreateReservationCommandHandler(IMapper mapper, IReservationRequestRepository reservationRequestRepository)
        {
            this._mapper = mapper;
            this._reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            //TODO: Validation incoming data
            var ReservationRequestToCreate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

            await _reservationRequestRepository.CreateAsync(ReservationRequestToCreate);

            return ReservationRequestToCreate.Id;
        }
    }
}