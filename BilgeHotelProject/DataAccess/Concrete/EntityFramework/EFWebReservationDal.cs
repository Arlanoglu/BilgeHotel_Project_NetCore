using DataAccess.Abstract;
using Entities.Concrete;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWebReservationDal : EFBaseDal<WebReservation>, IWebReservationDal
    {
        public string Reservation()
        {
            //Todo: Rezervasyon işlemi için test yapılacak.
            return "a";
        }
    }
}
