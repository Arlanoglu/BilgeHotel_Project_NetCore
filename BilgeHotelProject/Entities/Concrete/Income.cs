using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Income : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public int RegistrationID { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
