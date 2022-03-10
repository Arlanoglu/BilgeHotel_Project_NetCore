using Core.Entities;
using Entities.Enum;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public string Description { get; set; }
        public int RoomTypeID { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<StatusOfRoom> StatusOfRooms { get; set; }
        public virtual ICollection<WebReservation> WebReservations { get; set; }
        public virtual ICollection<Registration> Registirations { get; set; }
        public virtual ICollection<ReceptionReservation> ReceptionReservations { get; set; }

    }
}
