using Entities.Abstract;
using Core.Entities;
using System;
using Entities.Enum;

namespace Entities.Concrete
{
    public class WebReservation : BaseEntity, IBaseReservation
    {
        public WebReservation()
        {
            ReservationDate = DateTime.Now;
            ReservationStatus = ReservationStatus.ReservationReceived;
        }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; } //Nerede doldurulacak karar verilmedi
        public bool Payment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public ReservationStatus ReservationStatus { get; set; }       

        public int RoomID { get; set; } //Rondom atanacak
        public int? RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public string AppUserID { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ServicePack ServicePack { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
