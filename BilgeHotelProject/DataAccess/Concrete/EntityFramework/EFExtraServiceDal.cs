using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFExtraServiceDal : EFBaseDal<ExtraService>,IExtraServiceDal
    {
        public EFExtraServiceDal(AppDbContext db) : base(db)
        {
        }
    }
}
