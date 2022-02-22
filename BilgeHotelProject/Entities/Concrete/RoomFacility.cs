using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class RoomFacility : BaseEntity
    {
        public string FacilityName { get; set; }
        public string Description { get; set; }

        public virtual List<FacilityOfRoom> FacilityOfRooms { get; set; }
    }
}
