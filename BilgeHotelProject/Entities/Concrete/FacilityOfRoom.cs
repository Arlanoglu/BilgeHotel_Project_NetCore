using Core.Entities;

namespace Entities.Concrete
{
    public class FacilityOfRoom : BaseEntity
    {
        public int RoomTypeID { get; set; }
        public int RoomFacilityID { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual RoomFacility RoomFacility { get; set; }
        
    }
}
