using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.RoomFacility
{
    public class VMRoomFacilitySelection : BaseVM
    {
        public int FacilityID { get; set; }
        public string FacilityName { get; set; }
        public bool Selected { get; set; }
    }
}
