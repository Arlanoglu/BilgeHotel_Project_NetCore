using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomFacilityDal : EFBaseDal<RoomFacility>, IRoomFacilityDal
    {
        public EFRoomFacilityDal(IResult result) : base(result)
        {
        }
    }
}
