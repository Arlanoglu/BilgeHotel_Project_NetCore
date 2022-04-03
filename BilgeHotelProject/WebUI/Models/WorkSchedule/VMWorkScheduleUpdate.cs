using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.WorkSchedule
{
    public class VMWorkScheduleUpdate : BaseVM
    {
        public int WorkScheduleID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan TimesWorked { get; set; }
        public bool HaveOverTime { get; set; }
        public TimeSpan OverTimeHour { get; set; }
        public WorkStatus WorkStatus { get; set; }
        public string Description { get; set; }
    }
}
