using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StatusOfRoom : BaseEntity
    {
        public DateTime StatusStartDate { get; set; }
        public DateTime StatusEndDate { get; set; }

        public int RoomID { get; set; }
        public int RoomStatusID { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }

        //Todo: Map işlemlerinde Idsi ignore edilecek.
    }
}
