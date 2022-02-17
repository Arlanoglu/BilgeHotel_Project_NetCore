using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStatusOfRoomDal : EFBaseDal<StatusOfRoom>, IStatusOfRoomDal 
    {
    }
}
