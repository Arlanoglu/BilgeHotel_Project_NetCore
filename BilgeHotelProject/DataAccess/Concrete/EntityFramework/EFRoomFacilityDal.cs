using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomFacilityDal : EFBaseDal<RoomFacility>, IRoomFacilityDal
    {
        public EFRoomFacilityDal(AppDbContext db) : base(db)
        {
        }
    }
}
