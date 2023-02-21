using Microsoft.EntityFrameworkCore;
using YourCarSlot.Application.Contracts.Persistance;
using YourCarSlot.Domain.Entities;
using YourCarSlot.Infrastructure.EF.DatabaseContext;

namespace YourCarSlot.Infrastructure.Repository
{
    public class ReservationRequestRepository : GenericRepository<ReservationRequest>, IReservationRequestRepository
    {
        public ReservationRequestRepository(YCSDatabaseContext context) : base(context)
        {
        }

        public async Task<ReservationRequest> GetReservationRequestWithDetails(Guid id)
        {
            var ReservationRequest = await _context.ReservationRequest
                .Include(q => q.PlateNumber)
                .FirstOrDefaultAsync(q => q.Id == id);

                return ReservationRequest;
        }
    }
}