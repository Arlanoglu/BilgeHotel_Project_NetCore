using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
