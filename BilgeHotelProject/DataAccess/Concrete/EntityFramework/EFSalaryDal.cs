using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSalaryDal : EFBaseDal<Salary>, ISalaryDal
    {
        public EFSalaryDal(AppDbContext db) : base(db)
        {
        }
    }
}
