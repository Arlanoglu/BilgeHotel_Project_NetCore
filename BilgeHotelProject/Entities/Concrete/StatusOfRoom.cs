using Core.Entities;
using Entities.Enum;
using System;

namespace Entities.Concrete
{
    public class StatusOfRoom : BaseEntity
    {
        public DateTime StatusStartDate { get; set; }
        public DateTime StatusEndDate { get; set; }
        public RoomStatus RoomStatus { get; set; }

        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
    }
}
