using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.HomePage;
using WebUI.Models.RoomType;

namespace WebUI.Models.HomeIndex
{
    public class VMHomeIndex
    {
        public VMHomePage VMHomePage { get; set; }
        public List<VMHomePageSlide> VMHomePageSlides { get; set; }
        public List<VMRoomType> VMRoomTypes { get; set; }
        public List<VMRoomPicture> VMRoomPictures { get; set; }
    }
}
