using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStatusOfRoomDal : EFBaseDal<StatusOfRoom>, IStatusOfRoomDal
    {
        public EFStatusOfRoomDal(AppDbContext db) : base(db)
        {
        }
    }
}
