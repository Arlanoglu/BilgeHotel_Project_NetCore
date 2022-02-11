using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class StatusOfRoom : BaseEntity
    {
        public DateTime StatusStartDate { get; set; }
        public DateTime StatusEndDate { get; set; }

        public int RoomID { get; set; }
        public int RoomStatusID { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }

        //Todo: Map işlemlerinde Idsi ignore edilecek.
    }
}
