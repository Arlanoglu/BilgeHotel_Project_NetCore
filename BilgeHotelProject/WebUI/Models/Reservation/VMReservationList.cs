using Core.Entities.Enum;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Reservation
{
    public class VMReservationList : BaseVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

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
        public DateTime ReservationDate { get; set; }        
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool Payment { get; set; }        
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public ReservationType ReservationType { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public Status Status { get; set; }
    }
}
