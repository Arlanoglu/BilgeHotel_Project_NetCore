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

        public virtual List<Room> Rooms { get; set; }
        public virtual List<FacilityOfRoom> FacilityOfRooms { get; set; }
    }
}
