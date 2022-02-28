using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFReceptionReservationDal : EFBaseDal<ReceptionReservation>, IReceptionReservationDal
    {
        public EFReceptionReservationDal(AppDbContext db) : base(db)
        {
        }
    }
}
