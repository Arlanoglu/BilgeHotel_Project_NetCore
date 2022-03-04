using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFHotelServiceDal : EFBaseDal<HotelService>, IHotelServiceDal
    {
        public EFHotelServiceDal(AppDbContext db) : base(db)
        {
        }
    }
}
