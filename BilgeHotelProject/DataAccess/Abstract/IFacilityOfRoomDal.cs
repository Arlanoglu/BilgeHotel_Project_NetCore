using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IFacilityOfRoomDal : IEntityRepository<FacilityOfRoom>
    {
        public void RemoveForceModel(FacilityOfRoom model);
    }
}
