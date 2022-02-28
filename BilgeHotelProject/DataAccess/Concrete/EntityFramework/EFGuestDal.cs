using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFGuestDal : EFBaseDal<Guest>, IGuestDal
    {
        public EFGuestDal(AppDbContext db) : base(db)
        {
        }
    }
}
