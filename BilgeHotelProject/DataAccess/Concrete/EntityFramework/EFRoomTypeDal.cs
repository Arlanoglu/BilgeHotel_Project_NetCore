using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomTypeDal : EFBaseDal<RoomType>, IRoomTypeDal
    {
        private readonly AppDbContext db;

        public EFRoomTypeDal(AppDbContext db) : base(db)
        {
            this.db = db;
        }
        //Todo: Sorgu güncellenecek room tablosundan çekilecek.
        public async Task<List<RoomType>> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            var roomTypes = db.StatusesOfRooms.Where(x => ((x.StatusStartDate! <= checkinDate && x.StatusEndDate! >= checkinDate) || (x.StatusStartDate! <= checkoutDate && x.StatusEndDate! >= checkoutDate)) && x.RoomStatus == Entities.Enum.RoomStatus.Bos).Select(x => x.Room.RoomType);

            return await roomTypes.Where(x => x.NumberOfPeople == numberOfPeople).ToListAsync();
            //Todo: Karşılanan yerde (UIda) boş değilse liste gönderilecek boş ise viewbag ile mesaj gösterilecek.s
        }
    }
}
