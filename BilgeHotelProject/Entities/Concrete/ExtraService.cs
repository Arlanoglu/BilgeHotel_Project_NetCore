using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class ExtraService : BaseEntity
    {
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<UseOfExtraService> UseOfExtraServices { get; set; }
    }
}
