using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IReceptionReservationService : IService<ReceptionReservation>
    {
        public IResult CancelReservation(ReceptionReservation receptionReservation);
        public IResult ReservationCreate(ReceptionReservation receptionReservation, StatusOfRoom statusOfRoom);
        public Task<List<ReceptionReservation>> NotPaidReservatins();
    }
}
