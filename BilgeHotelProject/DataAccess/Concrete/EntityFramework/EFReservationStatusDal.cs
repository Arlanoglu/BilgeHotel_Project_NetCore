using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFReservationStatusDal : EFBaseDal<ReservationStatus>, IReservationStatusDal
    {
    }
}
