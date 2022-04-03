using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMEmployeeRoleSelection : BaseVM
    {
        public string RoleName { get; set; }
        public bool Selected { get; set; }
    }
}
