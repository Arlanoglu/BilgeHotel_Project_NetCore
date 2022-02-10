using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ServicePack : BaseEntity
    {
        public string PackName { get; set; }
        public string PackPrice { get; set; }
        public string Description { get; set; }

        public virtual List<WebReservation> WebReservations { get; set; }
        public virtual List<ReceptionReservation> ReceptionReservations { get; set; }
        public virtual List<Registration> Registirations { get; set; }
    }
}
