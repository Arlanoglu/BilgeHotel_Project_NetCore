using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Department
{
    public class VMDepartmentList : BaseVM
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
