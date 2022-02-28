using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFUseOfExtraServiceDal : EFBaseDal<UseOfExtraService>, IUseOfExtraServiceDal
    {
        public EFUseOfExtraServiceDal(AppDbContext db) : base(db)
        {
        }
    }
}
