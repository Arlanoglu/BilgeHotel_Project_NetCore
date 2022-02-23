using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWebReservationDal : EFBaseDal<WebReservation>, IWebReservationDal
    {
        public EFWebReservationDal(IResult result, AppDbContext db) : base(result,db)
        {
        }
    }
}
