using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.RoomType
{
    public class VMRoomType
    {
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfBed { get; set; }
        public decimal Price { get; set; }

        public List<VMRoomPicture> VMRoomPictures { get; set; }
    }
}
