using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;

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
            var validator = new CreateReservationCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                throw new BadRequestException("Invalid CreateReservation type", validatorResult);   
            }

            var reservationRequestToCreate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

            await _reservationRequestRepository.CreateAsync(reservationRequestToCreate);

            return reservationRequestToCreate.Id;
        }
    }
}