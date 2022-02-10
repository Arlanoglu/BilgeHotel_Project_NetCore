using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomFacility : BaseEntity
    {
        public string FacilityName { get; set; }
        public string Description { get; set; }
        public string IsItPaid { get; set; }
        //Todo: IsitPaid kontrol edilecek

        public virtual List<FacilityOfRoom> FacilityOfRooms { get; set; }
    }
}
