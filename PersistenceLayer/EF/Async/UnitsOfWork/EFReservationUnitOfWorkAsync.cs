using System.Threading.Tasks;
using SportsClubModel.CoreAbstractions.Async.Repositories;
using SportsClubModel.CoreAbstractions.Async.UnitsOfWork;

namespace PersistenceLayer.EF.Async.UnitsOfWork
{
    //temp
    public class EFReservationUnitOfWorkAsync : ReservationUnitOfWorkAsync
    {
        private readonly SportsClubContext ctx;
        public EFReservationUnitOfWorkAsync(SportsClubContext ctx, ReservationRepositoryAsync reservationRepository)
        {
            this.ctx= ctx;
            ReservationRepository = reservationRepository;
        }
        public ReservationRepositoryAsync ReservationRepository { get; set; }

        public async Task<int> SaveAsync()
        {
            return await ctx.SaveChangesAsync();
        }
    }
}