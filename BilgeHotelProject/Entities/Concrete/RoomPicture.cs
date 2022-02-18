using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomPicture : BaseEntity
    {
        public string Picture { get; set; }
        public int RoomTypeID { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
