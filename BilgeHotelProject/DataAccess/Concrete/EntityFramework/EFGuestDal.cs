using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFGuestDal : EFBaseDal<Guest>, IGuestDal
    {
        public EFGuestDal(IResult result) : base(result)
        {
        }
    }
}
