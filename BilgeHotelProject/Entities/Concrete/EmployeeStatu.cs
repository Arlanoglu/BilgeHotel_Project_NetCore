using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EmployeeStatu : BaseEntity
    {
        public string StatuName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
