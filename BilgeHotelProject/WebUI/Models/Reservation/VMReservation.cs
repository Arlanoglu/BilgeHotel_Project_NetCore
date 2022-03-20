using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;

namespace WebUI.Models.Reservation
{
    public class VMReservation : BaseVM
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int RoomTypeID { get; set; }
        public int ServicePackID { get; set; }

        public List<VMRoomType> VMRoomTypes { get; set; }
        public List<VMServicePack> VMServicePacks { get; set; }
    }
}
