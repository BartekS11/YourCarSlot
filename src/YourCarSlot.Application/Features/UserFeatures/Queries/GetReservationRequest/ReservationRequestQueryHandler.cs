using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Application.Exceptions;
using YourCarSlot.Shared.Abstractions.Mediator.CommandHandling;

namespace YourCarSlot.Application.Features.UserFeatures.Queries.GetReservationRequest;

public sealed class ReservationRequestQuery
{
    public sealed record Command(Guid Id) : IYcsRequest<ReservationRequestDto>;

    internal sealed class Handler : IRequestHandler<Command, ReservationRequestDto>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public Handler(IReservationRequestRepository reservationRequestRepository)
        {
            _reservationRequestRepository = reservationRequestRepository;
        }
        public async Task<ReservationRequestDto> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationRequestType = await _reservationRequestRepository.GetByIdAsync(request.Id, cancellationToken)
                ?? throw new NotFoundException($"Request with id: {request.Id} is not found");

            var data = ReservationRequestMapper.Map(reservationRequestType);

            return data;
        }
    }
}
