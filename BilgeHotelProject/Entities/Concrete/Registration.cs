using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Registration : BaseEntity
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public string RegistrationType { get; set; }
        public string Description { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
        //Todo: Giriş saati farketmeksizin 14:00 olacaktır. 
        public int ReservationID { get; set; }

        public int RoomID { get; set; }
        public int ServicePackID { get; set; }
        public virtual Room Room { get; set; }
        public virtual ServicePack ServicePack { get; set; }
    }
}
