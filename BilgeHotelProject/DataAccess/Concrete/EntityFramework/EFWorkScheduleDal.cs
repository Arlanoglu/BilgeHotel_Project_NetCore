using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWorkScheduleDal : EFBaseDal<WorkSchedule>, IWorkScheduleDal
    {
        public EFWorkScheduleDal(AppDbContext db) : base(db)
        {
        }
    }
}
