using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
