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

        
        public virtual List<WorkSchedule> WorkSchedules { get; set; }
        public virtual List<EmployeeShift> EmployeesShifts { get; set; }
    }
}
