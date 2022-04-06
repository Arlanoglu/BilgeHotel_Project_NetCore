using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.HomePage
{
    public class VMHomePageSlide : BaseVM
    {
        public int HomePageSlideID { get; set; }
        public string PictureName { get; set; }
        public string PictureUrl { get; set; }
        public int HomePageID { get; set; }
        public Status Status { get; set; }
    }
}
