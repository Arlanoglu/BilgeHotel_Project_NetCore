using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFReceptionReservationDal : EFBaseDal<ReceptionReservation>, IReceptionReservationDal
    {
        public EFReceptionReservationDal(IResult result) : base(result)
        {
        }
    }
}
