using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBaseReservation
    {
        DateTime RezervationDate { get; set; }
        DateTime CheckInDate { get; set; }
        DateTime CheckOutDate { get; set; }
        int NumberOfPeople { get; set; }
        decimal Price { get; set; }
        bool Payment { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string IdentificationNumber { get; set; }
        public string Adress { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Description { get; set; }
        string RezervationType { get; set; }
        int RoomID { get; set; }
        int ReservationStatusID { get; set; }
        int ServicePackID { get; set; }
    }
}
