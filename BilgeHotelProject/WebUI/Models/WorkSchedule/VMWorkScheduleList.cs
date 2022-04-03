using Core.Entities.Enum;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.WorkSchedule
{
    public class VMWorkScheduleList : BaseVM
    {
        public int WorkScheduleID { get; set; }
        public DateTime Date { get; set; }
        public string EmployeeFullName { get; set; }
        public WorkStatus WorkStatus { get; set; }
        public string ShiftName { get; set; }
        public Status Status { get; set; }
    }
}
