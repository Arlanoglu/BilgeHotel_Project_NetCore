using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class EmployeeStatus : BaseEntity
    {
        public string StatuName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
