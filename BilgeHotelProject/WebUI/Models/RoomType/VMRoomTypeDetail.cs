using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomFacility;

namespace WebUI.Models.RoomType
{
    public class VMRoomTypeDetail : BaseVM
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfBed { get; set; }
        public decimal Price { get; set; }

        public List<VMRoomFacility> VMRoomFacilities { get; set; }
    }
}
