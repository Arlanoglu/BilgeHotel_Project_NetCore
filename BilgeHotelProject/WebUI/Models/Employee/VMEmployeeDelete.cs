using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMEmployeeDelete : BaseVM
    {
        public int ID { get; set; }
        public string IdentificationNumber { get; set; }
        public string Title { get; set; }
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
        public string DepartmentName { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public DateTime LeavingWorkDate { get; set; }
        [Required(ErrorMessage = "Ayrılış nedeni boş bırakılamaz.")]
        public string ReasonForLeaving { get; set; }
    }
}
