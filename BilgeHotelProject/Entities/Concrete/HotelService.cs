using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HotelService : BaseEntity
    {
        public string? IconCode { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }

        public virtual List<Setting> Settings { get; set; }
    }
}
