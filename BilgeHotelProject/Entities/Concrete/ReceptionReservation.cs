using Entities.Abstract;
using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class ReceptionReservation : BaseEntity, IBaseReservation
    {
        public DateTime RezervationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public bool Payment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string RezervationType { get; set; }
        public int RoomID { get; set; }
        public int ReservationStatusID { get; set; }
        public int ServicePackID { get; set; }
        public virtual Room Room { get; set; }
        public virtual ReservationStatus RezervationStatus { get; set; }
        public virtual ServicePack ServicePack { get; set; }
    }
}
