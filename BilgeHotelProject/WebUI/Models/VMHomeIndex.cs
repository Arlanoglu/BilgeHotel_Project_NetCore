using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.HomePage;
using WebUI.Models.RoomType;

namespace WebUI.Models
{
    public class VMHomeIndex : BaseVM
    {
        public VMHomePage VMHomePage { get; set; }
        public List<VMRoomType> VMRoomTypes { get; set; }
    }
}
