using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WorkSchedule : BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan TimesWorked { get; set; }
        public bool HaveOverTime { get; set; }
        public TimeSpan OverTimeHour { get; set; }
        public string Description { get; set; }
        public decimal DailyEarnings { get; set; }

        public Guid EmployeeID { get; set; }
        public Guid ShiftID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
