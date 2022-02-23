using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomDal : EFBaseDal<Room>, IRoomDal
    {
        public EFRoomDal(IResult result) : base(result)
        {
        }
    }
}
