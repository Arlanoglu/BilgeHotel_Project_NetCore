using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMEmployeeRoleSelectionCombine : BaseVM
    {
        public int EmployeeID { get; set; }
        public List<VMEmployeeRoleSelection> VMEmployeeRoleSelections { get; set; }
    }
}
