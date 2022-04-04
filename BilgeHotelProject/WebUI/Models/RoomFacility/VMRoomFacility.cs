using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.RoomFacility
{
    public class VMRoomFacility : BaseVM
    {
        public int ID { get; set; }
        public string FacilityName { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
