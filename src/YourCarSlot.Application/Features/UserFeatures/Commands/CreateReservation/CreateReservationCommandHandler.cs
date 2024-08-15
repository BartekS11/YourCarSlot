using MediatR;
using YourCarSlot.Application.Contracts.Persistance;
using static YourCarSlot.Domain.Entities.ReservationRequest;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;

public sealed class CreateReservationHandler
{
    public sealed record Command(
        PartOfTheDay PartOfTheDayReservation,
        DateTime BookingRequestTime,
        Guid UserRequestingId,
        int ParkingSlotRequesting,
        string PlateNumber) : IRequest<Guid>;

    internal sealed class Handler : IRequestHandler<Command, Guid>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public Handler(
            IReservationRequestRepository reservationRequestRepository)
        {
            _reservationRequestRepository = reservationRequestRepository;
        }

        public async Task<Guid> Handle(Command request, CancellationToken cancellationToken)
        {
            var reservationRequestToCreate = ReservationRequestMapper.Map(request);
            await _reservationRequestRepository.CreateAsync(reservationRequestToCreate, cancellationToken);

            return reservationRequestToCreate.Id;
        }
    }
}
