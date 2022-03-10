using Entities.Abstract;
using Core.Entities;
using System;
using Entities.Enum;

namespace Entities.Concrete
{
    public class ReceptionReservation : BaseEntity, IBaseReservation
    {
        public ReceptionReservation()
        {
            ReservationDate = DateTime.Now;
            ReservationStatus = ReservationStatus.ReservationReceived;
        }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        //Todo: Price için Encapsulation uygulanacak.
        public bool Payment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public ReservationStatus ReservationStatus { get; set; }

        public int RoomID { get; set; }
        public int? RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ServicePack ServicePack { get; set; }
    }
}
