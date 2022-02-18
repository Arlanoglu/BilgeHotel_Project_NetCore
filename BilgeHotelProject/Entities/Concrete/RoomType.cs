using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomType : BaseEntity
    {
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfBed { get; set; }
        public decimal Price { get; set; }

        public virtual List<Room> Rooms { get; set; }
        public virtual List<FacilityOfRoom> FacilityOfRooms { get; set; }
        public virtual List<WebReservation> WebReservations { get; set; }
        public virtual List<ReceptionReservation> ReceptionReservations { get; set; }
        public virtual List<RoomPicture> RoomPictures { get; set; }


    }
}
