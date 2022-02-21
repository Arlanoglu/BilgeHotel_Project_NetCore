using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWebReservationDal : EFBaseDal<WebReservation>, IWebReservationDal
    {
        public EFWebReservationDal(IResult result) : base(result)
        {
        }
    }
}
