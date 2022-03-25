using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.RoomType
{
    public class VMRoomPicture : BaseVM
    {
        public int ID { get; set; }
        public string PictureUrl { get; set; }
        public int RoomTypeID { get; set; }
        public Status Status { get; set; }
    }
}
