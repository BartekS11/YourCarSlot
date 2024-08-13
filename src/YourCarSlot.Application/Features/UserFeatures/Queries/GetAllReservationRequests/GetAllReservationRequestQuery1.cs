using AutoMapper;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetAllReservationRequests;

public sealed class GetAllReservationRequestQuery
{
    public sealed record Command : IRequest<ReservationRequestDto[]>;

    internal sealed class Handler : IRequestHandler<Command, ReservationRequestDto[]>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRequestRepository _reservationrequestRepository;

        public Handler(IMapper mapper, IReservationRequestRepository reservationrequestRepository)
        {
            _mapper = mapper;
            _reservationrequestRepository = reservationrequestRepository;
        }

        public async Task<ReservationRequestDto[]> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationTypes = await _reservationrequestRepository.GetAsync(cancellationToken) 
                ?? throw new NotFoundException("Reservation request is empty");

            var data = _mapper.Map<ReservationRequestDto[]>(reservationTypes);

            return data;
        }
    }
}
