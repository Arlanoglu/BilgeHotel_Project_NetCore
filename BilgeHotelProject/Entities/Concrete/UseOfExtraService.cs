using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UseOfExtraService : BaseEntity
    {
        public int ExtraServiceID { get; set; }
        public int RegistrationID { get; set; }
        public virtual ExtraService ExtraService { get; set; }
        public virtual Registration Registiration { get; set; }
    }
}
