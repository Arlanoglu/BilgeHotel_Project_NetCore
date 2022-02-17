using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWebReservationDal : EFBaseDal<WebReservation>, IWebReservationDal
    {
    }
}
