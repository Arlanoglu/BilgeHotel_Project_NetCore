using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HomePage : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string PictureUrl { get; set; }
        public string Paragraph1 { get; set; }
        public string? Paragraph2 { get; set; }
        public string? Paragraph3 { get; set; }
        public string? Paragraph4 { get; set; }
        public string? Paragraph5 { get; set; }

        public virtual List<HomePageSlide> HomePageSlides { get; set; }
        public virtual List<Setting> Settings { get; set; }
    }
}
