using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WorkSchedule : BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan TimesWorked { get; set; }
        public bool HaveOverTime { get; set; }
        //Todo: Girilen bilgieye göre burada true false gönderilecek.
        public TimeSpan OverTimeHour { get; set; }
        public string Description { get; set; }
        public decimal DailyEarnings { get; set; }

        public int EmployeeID { get; set; }
        public int ShiftID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
