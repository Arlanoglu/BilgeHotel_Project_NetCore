using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FacilityOfRoom : BaseEntity
    {
        public int RoomID { get; set; }
        public int RoomFacilityID { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomFacility RoomFacility { get; set; }

        //Todo: Map işlemlerinde Idsi ignore edilecek.
    }
}
