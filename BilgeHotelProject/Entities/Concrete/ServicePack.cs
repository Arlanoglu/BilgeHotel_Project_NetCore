using Core.Entities;
using System.Collections.Generic;

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
