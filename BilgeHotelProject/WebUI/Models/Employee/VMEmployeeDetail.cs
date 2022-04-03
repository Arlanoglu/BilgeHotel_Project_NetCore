using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMEmployeeDetail : BaseVM
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
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentName { get; set; }
        public string ShiftName { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public bool IsActive { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal OvertimePay { get; set; }
        public DateTime LeavingWorkDate { get; set; }
        public string ReasonForLeaving { get; set; }
        public string UserID { get; set; }
        public string[] Roles { get; set; }
    }
}
