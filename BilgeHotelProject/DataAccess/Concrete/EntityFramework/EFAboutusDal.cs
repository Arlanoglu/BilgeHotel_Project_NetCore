using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFAboutusDal : EFBaseDal<Aboutus>, IAboutusDal
    {
        public EFAboutusDal(AppDbContext db) : base(db)
        {

        }
    }
}
