using AutoMapper;
using FluentValidation;
using MediatR;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.CreateReservation;

public sealed class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IReservationRequestRepository _reservationRequestRepository;
    private readonly IValidator<CreateReservationCommand> _validator;

    public CreateReservationCommandHandler(
        IMapper mapper, 
        IReservationRequestRepository reservationRequestRepository,
        IValidator<CreateReservationCommand> validator)
    {
        _mapper = mapper;
        _reservationRequestRepository = reservationRequestRepository;
        _validator = validator;
    }

    public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        await _validator.ValidateAsync(request, cancellationToken);

        var reservationRequestToCreate = _mapper.Map<Domain.Entities.ReservationRequest>(request);

        await _reservationRequestRepository.CreateAsync(reservationRequestToCreate, cancellationToken);

        return reservationRequestToCreate.Id;
    }
}