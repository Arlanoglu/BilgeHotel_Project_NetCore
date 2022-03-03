using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HomePageSlide : BaseEntity
    {
        public string PictureName { get; set; }
        public string PictureUrl { get; set; }

        public int HomePageID { get; set; }
        public virtual HomePage HomePage { get; set; }
    }
}
