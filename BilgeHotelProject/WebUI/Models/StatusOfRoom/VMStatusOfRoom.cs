using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.StatusOfRoom
{
    public class VMStatusOfRoom : BaseVM
    {
        public DateTime StatusStartDate { get; set; }
        public DateTime StatusEndDate { get; set; }
        public RoomStatus RoomStatus { get; set; }

        public int RoomID { get; set; }
    }
}
