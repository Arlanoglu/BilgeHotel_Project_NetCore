using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMAddShiftToEmployeeCombine : BaseVM
    {
        public List<VMAddShiftToEmployee> Employees { get; set; }
        public int ShiftID { get; set; }
        public string ShiftName { get; set; }
    }
}
