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
        
        public async Task<List<RoomType>> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            var rooms = await db.Rooms.Where(x => (x.StatusOfRooms.Any(x=> (!(x.StatusStartDate <= checkinDate && x.StatusEndDate > checkinDate) && !(x.StatusStartDate < checkoutDate && x.StatusEndDate >= checkoutDate)) && x.Status == Core.Entities.Enum.Status.Active) || x.StatusOfRooms.Count == 0) && x.RoomStatus != Entities.Enum.RoomStatus.Tadilat).ToListAsync();

            var rooms2 = rooms.Where(x => x.RoomType.NumberOfPeople >= numberOfPeople).ToList();

            List<RoomType> roomTypes = new List<RoomType>();
            foreach (var item in db.RoomTypes)
            {
                if (rooms2.Any(x=>x.RoomTypeID==item.ID))
                {
                    roomTypes.Add(item);
                }
            }
            //rooms.Where(x => x.RoomType.NumberOfPeople == numberOfPeople).Select(x => x.RoomType).ToList();
            return roomTypes;
            //Todo: Karşılanan yerde (UIda) boş değilse liste gönderilecek boş ise viewbag ile mesaj gösterilecek.s
        }
    }
}
