using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Picture
{
    public class VMPicture : BaseVM
    {
        public int PictureID { get; set; }
        public string PictureName { get; set; }
        public string PictureUrl { get; set; }
        public Status Status { get; set; }
        public int AboutusID { get; set; }
    }
}
