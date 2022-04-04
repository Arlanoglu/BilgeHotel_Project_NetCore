using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Room
{
    public class VMRoomUpdate
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public string Description { get; set; }
    }
}
