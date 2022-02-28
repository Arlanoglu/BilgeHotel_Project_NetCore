using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFFacilityOfRoomDal : EFBaseDal<FacilityOfRoom>, IFacilityOfRoomDal
    {
        public EFFacilityOfRoomDal(AppDbContext db) : base(db)
        {
        }
    }
}
