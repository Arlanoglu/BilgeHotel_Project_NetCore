using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IRegistrationService : IService<Registration>
    {
        public IResult CreateRegistrationWithoutReservation(Registration registration, StatusOfRoom statusOfRoom);
    }
}
