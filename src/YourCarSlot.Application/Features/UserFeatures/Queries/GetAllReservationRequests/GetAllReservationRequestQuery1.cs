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
        private readonly IReservationRequestRepository _reservationrequestRepository;

        public Handler(IReservationRequestRepository reservationrequestRepository)
        {
            _reservationrequestRepository = reservationrequestRepository;
        }

        public async Task<ReservationRequestDto[]> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationTypes = await _reservationrequestRepository.GetAsync(cancellationToken) 
                ?? throw new NotFoundException("Reservation request is empty");
            
            var data = Array.Empty<ReservationRequestDto>();
            foreach(var res in reservationTypes)
            {
                var item = ReservationRequestMapper.Map(res);
                _ = data.Append(item);
            }

            return data;
        }
    }
}
