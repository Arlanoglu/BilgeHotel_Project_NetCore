using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Contact;
using WebUI.Models.RoomType;

namespace WebUI.Models
{
    public class VMFooter
    {
        public VMContact VMContact { get; set; }
        public List<VMRoomTypeName> VMRoomTypeNames { get; set; }
    }
}
