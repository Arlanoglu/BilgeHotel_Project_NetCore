using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HotelService : BaseEntity
    {
        public string IconPicture { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }

        //public int SettingID { get; set; }
        //public virtual Setting Setting { get; set; }
    }
}
