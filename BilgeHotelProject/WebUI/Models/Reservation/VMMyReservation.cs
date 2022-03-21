using Core.Entities.Enum;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;

namespace WebUI.Models.Reservation
{
    public class VMMyReservation
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool Payment { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public Status Status { get; set; }
        public VMRoomTypeName VMRoomTypeName { get; set; }
        public VMServicePack VMServicePack { get; set; }
    }
}
