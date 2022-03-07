using Core.Entities;
using Entities.Enum;
using System;

namespace Entities.Concrete
{
    public class WorkSchedule : BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan TimesWorked { get; set; }
        public bool HaveOverTime { get; set; }
        public TimeSpan? OverTimeHour { get; set; }
        public bool IsHoliday { get; set; }
        public Holiday? Holiday { get; set; }
        public string Description { get; set; }

        public int EmployeeID { get; set; }
        public int? ShiftPlanID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ShiftPlan ShiftPlan { get; set; }
    }
}