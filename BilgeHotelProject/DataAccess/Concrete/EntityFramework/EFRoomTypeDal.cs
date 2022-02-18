using Core.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomTypeDal : EFBaseDal<RoomType>, IRoomTypeDal
    {
        public EFRoomTypeDal(IResult result) : base(result)
        {
        }

        //Todo: Db instence ı Dependecy injection uygulanacak. Önce test edilip sonra sıkı bağımlılık kaldırılacak.
        public List<RoomType> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            AppDbContext db = new AppDbContext();
            var roomTypes = db.StatusesOfRooms.Where(x => ((x.StatusStartDate! <= checkinDate && x.StatusEndDate! >= checkinDate) || (x.StatusStartDate! <= checkoutDate && x.StatusEndDate! >= checkoutDate)) && x.RoomStatus == Entities.Enum.RoomStatus.Bos).Select(x => x.Room.RoomType);

            return roomTypes.Where(x => x.NumberOfPeople == numberOfPeople).ToList();
            //Todo: Karşılanan yerde (UIda) boş değilse liste gönderilecek boş ise viewbag ile mesaj gösterilecek.
        }
    }
}
