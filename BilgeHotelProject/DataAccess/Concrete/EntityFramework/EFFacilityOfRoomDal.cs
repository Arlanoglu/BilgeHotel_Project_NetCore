using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFFacilityOfRoomDal : EFBaseDal<FacilityOfRoom>, IFacilityOfRoomDal
    {
        private readonly AppDbContext db;

        public EFFacilityOfRoomDal(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public void RemoveForceModel(FacilityOfRoom model)
        {
            db.FacilitiesOfRooms.Remove(model);
        }
    }
}
