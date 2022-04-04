using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.RoomFacility
{
    public class VMRoomFacilitySelectionCombine : BaseVM
    {
        public int RoomTypeID { get; set; }
        public List<VMRoomFacilitySelection> VMRoomFacilitySelections { get; set; }
    }
}
