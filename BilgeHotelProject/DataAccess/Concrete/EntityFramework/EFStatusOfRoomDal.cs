using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStatusOfRoomDal : EFBaseDal<StatusOfRoom>, IStatusOfRoomDal
    {
        public EFStatusOfRoomDal(IResult result) : base(result)
        {
        }
    }
}
