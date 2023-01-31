using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using YourCarSlot.Application.Contracts.Persistance;

namespace YourCarSlot.Application.Features.UserFeatures.Commands.UpdateReservation
{
    public class UpdateReservationCommandValidator : AbstractValidator<UpdateReservationCommand>
    {
        private readonly IReservationRequestRepository _reservationRequestRepository;

        public UpdateReservationCommandValidator(IReservationRequestRepository reservationRequestRepository)
        {  
            RuleFor(p => p.Id)
                .NotNull()
                .MustAsync(ReservationMustExist);

            RuleFor(p => p.ParkingSlotRequesting)
                .NotNull();

            RuleFor(p => p.Id)
                .MustAsync(ReservationMustExist);
                
            this._reservationRequestRepository = reservationRequestRepository;
        }

        private async Task<bool> ReservationMustExist(Guid id, CancellationToken arg2)
    {
        var reservationType = await _reservationRequestRepository.GetByIdAsync(id);
        return reservationType != null;
    }
    }
}