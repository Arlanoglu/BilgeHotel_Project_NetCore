using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFGuestDal : EFBaseDal<Guest>, IGuestDal
    {
    }
}
