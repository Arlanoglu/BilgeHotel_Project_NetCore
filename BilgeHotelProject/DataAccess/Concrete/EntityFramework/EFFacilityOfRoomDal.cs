using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFFacilityOfRoomDal : EFBaseDal<FacilityOfRoom>, IFacilityOfRoomDal
    {
        public EFFacilityOfRoomDal(IResult result) : base(result)
        {
        }
    }
}
