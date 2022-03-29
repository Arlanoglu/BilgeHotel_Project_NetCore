using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ExtraService;
using WebUI.Models.Guest;

namespace WebUI.Models.Registration
{
    public class VMRegistrationDetail
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }
        public int? ReservationID { get; set; }

        public int RoomID { get; set; }
        public int ServicePackID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public string ServicePackName { get; set; }
        public List<VMGuestRegistrationList> VMGuests { get; set; }
        public List<VMExtraService> VMExtraServices { get; set; }
    }
}
