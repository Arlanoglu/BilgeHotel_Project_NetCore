using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Picture;

namespace WebUI.Models.Aboutus
{
    public class VMAboutus
    {
        public string Title { get; set; }
        public string PictureUrl { get; set; }
        public string Paragraph1 { get; set; }
        public string Paragraph2 { get; set; }
        public string Paragraph3 { get; set; }
        public string Paragraph4 { get; set; }
        public string Paragraph5 { get; set; }

        public List<VMPicture> VMPictures { get; set; }
    }
}
