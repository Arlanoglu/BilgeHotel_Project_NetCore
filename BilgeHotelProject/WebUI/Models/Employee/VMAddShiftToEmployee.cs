using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMAddShiftToEmployee
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string DepartmentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _fullName;
        public string FullName
        {
            get
            {
                _fullName = FirstName + " " + LastName;
                return _fullName;
            }
        }
        public bool Selected { get; set; }
    }
}
