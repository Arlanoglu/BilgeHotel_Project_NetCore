using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFReceptionReservationDal : EFBaseDal<ReceptionReservation>, IReceptionReservationDal 
    {
    }
}
