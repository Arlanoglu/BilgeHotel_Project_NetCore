using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEmployeeDal : EFBaseDal<Employee>, IEmployeeDal
    {
        public EFEmployeeDal(AppDbContext db) : base(db)
        {
        }
    }
}
