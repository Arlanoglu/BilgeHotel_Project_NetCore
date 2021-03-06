using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFShiftDal : EFBaseDal<Shift>, IShiftDal
    {
        public EFShiftDal(AppDbContext db) : base(db)
        {
        }
    }
}
