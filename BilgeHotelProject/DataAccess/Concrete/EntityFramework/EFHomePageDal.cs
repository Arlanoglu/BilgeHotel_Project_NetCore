using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFHomePageDal : EFBaseDal<HomePage>, IHomePageDal
    {
        public EFHomePageDal(AppDbContext db) : base(db)
        {
        }
    }
}
