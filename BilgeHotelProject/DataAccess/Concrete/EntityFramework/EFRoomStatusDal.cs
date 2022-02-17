using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomStatusDal : EFBaseDal<RoomStatus>, IRoomStatusDal
    {
    }
}
