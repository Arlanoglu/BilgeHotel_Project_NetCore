using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.HomePage
{
    public class VMHomePage : BaseVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string PictureUrl { get; set; }
        public string Paragraph1 { get; set; }
        public string Paragraph2 { get; set; }
        public string Paragraph3 { get; set; }
        public string Paragraph4 { get; set; }
        public string Paragraph5 { get; set; }
        public Status Status { get; set; }

        public List<VMHomePageSlide> VMHomePageSlide { get; set; }
    }
}
