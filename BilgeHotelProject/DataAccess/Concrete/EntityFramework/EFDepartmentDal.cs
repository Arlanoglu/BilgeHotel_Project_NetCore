using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFDepartmentDal : EFBaseDal<Department>, IDepartmentDal
    {
        public EFDepartmentDal(AppDbContext db) : base(db)
        {
        }
    }
}
