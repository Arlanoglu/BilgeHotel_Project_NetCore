using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IWebReservationService : IService<WebReservation>
    {
        public decimal DiscountPrice(decimal reservationPrice, DateTime checkInDate, DateTime reservationDate, string servicePackName);
        public IResult ReservationCreate(WebReservation webReservation, StatusOfRoom statusOfRoom);
        public IResult CancelReservation(WebReservation webReservation);
    }
}
