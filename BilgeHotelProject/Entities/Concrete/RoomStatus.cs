using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomStatus : BaseEntity
    {
        public string Status { get; set; }

        public virtual List<StatusOfRoom> StatusOfRooms { get; set; }
    }
}
