using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomDal : EFBaseDal<Room>, IRoomDal
    {
    }
}
