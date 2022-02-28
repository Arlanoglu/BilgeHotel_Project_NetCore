using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRegistrationDal : EFBaseDal<Registration>, IRegistrationDal
    {
        public EFRegistrationDal(AppDbContext db) : base(db)
        {
        }
    }
}
