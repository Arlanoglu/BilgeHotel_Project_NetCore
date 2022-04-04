using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Room
{
    public class VMRoomCreate : BaseVM
    {
        public string RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public string Description { get; set; }
        public int RoomTypeID { get; set; }
    }
}
