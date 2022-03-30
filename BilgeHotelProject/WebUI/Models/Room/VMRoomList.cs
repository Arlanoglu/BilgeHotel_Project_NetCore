using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Room
{
    public class VMRoomList : BaseVM
    {
        public int ID { get; set; }
        public string RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public string RoomTypeName { get; set; }
        public int RegistrationID { get; set; }
    }
}
