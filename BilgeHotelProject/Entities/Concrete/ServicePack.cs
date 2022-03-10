using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class ServicePack : BaseEntity
    {
        public string PackName { get; set; }
        public decimal PackPrice { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WebReservation> WebReservations { get; set; }
        public virtual ICollection<ReceptionReservation> ReceptionReservations { get; set; }
        public virtual ICollection<Registration> Registirations { get; set; }
    }
}
