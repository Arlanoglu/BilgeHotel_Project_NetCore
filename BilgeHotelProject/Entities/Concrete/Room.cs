using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfBed { get; set; }
        public string Description { get; set; }
        public decimal RoomPrice { get; set; }
        public string RoomImage { get; set; }

        public virtual List<FacilityOfRoom> FacilityOfRooms { get; set; }
        public virtual List<StatusOfRoom> StatusOfRooms { get; set; }
        public virtual List<WebReservation> WebReservations { get; set; }
        public virtual List<Registration> Registirations { get; set; }
        public virtual List<ReceptionReservation> ReceptionReservations { get; set; }

    }
}
