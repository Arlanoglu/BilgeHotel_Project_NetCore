using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EmployeeShift : BaseEntity
    {
        public string EmployeeID { get; set; }
        public string ShiftID { get; set; }
        //public virtual Employee Employee { get; set; }
        //public virtual Shift Shift { get; set; }
    }
}
