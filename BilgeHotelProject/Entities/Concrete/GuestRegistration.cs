using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GuestRegistration : BaseEntity
    {
        public int RegistrationID { get; set; }
        public int GuestID { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
