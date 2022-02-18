using DataAccess.Abstract;
using Entities.Concrete;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWebReservationDal : EFBaseDal<WebReservation>, IWebReservationDal
    {
        private readonly IRoomDal room;
        private readonly IStatusOfRoomDal statusOfRoom;

        public EFWebReservationDal(IRoomDal room, IStatusOfRoomDal statusOfRoom)
        {
            this.room = room;
            this.statusOfRoom = statusOfRoom;
        }
        public string Reservation(WebReservation reservation)
        {
            //Todo: Düzenlenecek.
            var rooms = room.GetDefault(x => x.RoomTypeID == reservation.RoomTypeID);
            var roomstatus = statusOfRoom.GetList();
            var r = statusOfRoom.GetDefault(x => x.Room.RoomTypeID == reservation.RoomTypeID && ((x.StatusStartDate! <= reservation.CheckInDate && x.StatusEndDate! >= reservation.CheckInDate) || (x.StatusStartDate! <= reservation.CheckOutDate && x.StatusEndDate! >= reservation.CheckOutDate)) && (x.RoomStatus.StatusName != "Tadilat" || x.RoomStatus.StatusName != "Dolu" ||));

            return "a";
        }
    }
}
