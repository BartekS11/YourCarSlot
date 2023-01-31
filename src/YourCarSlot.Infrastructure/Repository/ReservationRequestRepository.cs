using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository
{
    public class ReservationRequestRepository : GenericRepository<ReservationRequestRepository>, IReservationRequestRepository
    {
        public ReservationRequestRepository(YCSDatabaseContext context) : base(context)
        {
        }

        public Task CreateAsync(ReservationRequest entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ReservationRequest entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ReservationRequest entity)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<ReservationRequest>> IGenericRepository<ReservationRequest>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<ReservationRequest> IGenericRepository<ReservationRequest>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}