using Core.Entities.Enum;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.WorkSchedule
{
    public class VMWorkScheduleDetail : BaseVM
    {
        public int WorkScheduleID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan TimesWorked { get; set; }
        public bool HaveOverTime { get; set; }
        public TimeSpan? OverTimeHour { get; set; }
        public WorkStatus WorkStatus { get; set; }
        public string Description { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeeTitle { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan ShiftStartTime { get; set; }
        public TimeSpan ShiftEndTime { get; set; }
        public Status Status { get; set; }

        public int EmployeeID { get; set; }
    }
}
