using Core.Entities;
using Entities.Enum;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class ShiftPlan : BaseEntity
    {
        public string WeekNumber { get; set; }
        public DateTime Date { get; set; }
        public Shift Shift { get; set; }
        public bool IsHoliday { get; set; }
        public Holiday Holiday { get; set; }
        public string Description { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual List<WorkSchedule> WorkSchedules { get; set; }
    }
}
