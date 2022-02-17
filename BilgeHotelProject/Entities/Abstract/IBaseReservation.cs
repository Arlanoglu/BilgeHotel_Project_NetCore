using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBaseReservation
    {
        DateTime ReservationDate { get; set; }
        DateTime CheckInDate { get; set; }
        DateTime CheckOutDate { get; set; }
        int NumberOfPeople { get; set; }
        decimal Price { get; set; }
        bool Payment { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Description { get; set; }
        int RoomID { get; set; }
        int ServicePackID { get; set; }
    }
}
