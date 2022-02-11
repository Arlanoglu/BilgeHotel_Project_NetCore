using Core.Entities;
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

        public virtual List<Employee> Employees { get; set; }
        public virtual List<WorkSchedule> WorkSchedules { get; set; }
    }
}
