using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.RoomType
{
    public class VMRoomTypeName : BaseVM
    {
        public int ID { get; set; }
        public string RoomTypeName { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
