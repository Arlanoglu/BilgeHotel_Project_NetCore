using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFIncomeDal : EFBaseDal<Income>, IIncomeDal
    {
        public EFIncomeDal(AppDbContext db) : base(db)
        {
        }
    }
}
