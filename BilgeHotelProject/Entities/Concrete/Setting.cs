using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Setting : BaseEntity
    {
        public string SmtpHost { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpEmail { get; set; }
        public string SmtpPassword { get; set; }

        public int HomePageID { get; set; }
        public int AboutusID { get; set; }
        public int ContactID { get; set; }
        public virtual HomePage HomePage { get; set; }
        public virtual Aboutus Aboutus { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual List<HotelService> HotelServices { get; set; }
    }
}
