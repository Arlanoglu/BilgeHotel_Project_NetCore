using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomDal : EFBaseDal<Room>, IRoomDal
    {
        private readonly AppDbContext db;

        public EFRoomDal(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public async Task<List<Room>> AvaibleRooms(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            var rooms = await db.Rooms.Where(x => (x.StatusOfRooms.Any(x => (!(x.StatusStartDate <= checkinDate && x.StatusEndDate > checkinDate) && !(x.StatusStartDate < checkoutDate && x.StatusEndDate >= checkoutDate)) && x.Status == Core.Entities.Enum.Status.Active) || x.StatusOfRooms.Count == 0) && x.RoomStatus != Entities.Enum.RoomStatus.Tadilat).ToListAsync();
            //statusofroom içinde pasif olanıda eliyor kontrol edilecek.
            var roomsByNumberOfPeople = rooms.Where(x => x.RoomType.NumberOfPeople >= numberOfPeople).ToList();
             //&& (x.Status != Core.Entities.Enum.Status.Active)
            return roomsByNumberOfPeople;
        }
    }
}
