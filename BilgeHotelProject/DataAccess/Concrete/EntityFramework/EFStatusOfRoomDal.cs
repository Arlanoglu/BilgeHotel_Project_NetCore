using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStatusOfRoomDal : EFBaseDal<StatusOfRoom>, IStatusOfRoomDal
    {
        public EFStatusOfRoomDal(IResult result, AppDbContext db) : base(result,db)
        {
        }
    }
}
