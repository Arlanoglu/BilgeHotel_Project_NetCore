using Core.Entities.Enum;
using Entities.Concrete;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Reservation
{
    public class VMReservationDetail
    {
        public int ID { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        private string _fullname;
        public string FullName
        {
            get
            {
                if (FirstName != null && LastName != null)
                {
                    _fullname = $"{FirstName} {LastName}";
                }
                else
                {
                    _fullname = null;
                }
                return _fullname;
            }
        }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool Payment { get; set; }
        public int NumberOfPeople { get; set; }
        public ReservationType ReservationType { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public Status Status { get; set; }

        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public string AppUserID { get; set; }
        public string AppUserFullName { get; set; }
        public string AppUserEmail { get; set; }
        public string RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public string ServicePackName { get; set; }
    }
}
