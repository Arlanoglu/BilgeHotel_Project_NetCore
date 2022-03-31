using Core.Entities;
using Entities.Enum;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Shift : BaseEntity
    {
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        //public virtual ICollection<WorkSchedule> WorkSchedules { get; set; }
        //public virtual ICollection<EmployeeShift> EmployeesShifts { get; set; }
    }
}
