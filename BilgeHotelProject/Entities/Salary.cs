using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Salary : BaseEntity
    {
        public decimal MounthlySalary { get; set; }
        public bool BeenPaid { get; set; }
        public string Description { get; set; }

        public Guid EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
