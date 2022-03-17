using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Reservation
{
    public class VMWebReservation : BaseVM
    {
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

        public int RoomID { get; set; } //Rondom atanacak
        public int RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public string AppUserID { get; set; }
    }
}
