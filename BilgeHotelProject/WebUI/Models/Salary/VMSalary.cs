using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Salary
{
    public class VMSalary : BaseVM
    {
        public int SalaryID { get; set; }
        public decimal MonthlySalary { get; set; }
        public bool BeenPaid { get; set; }
        public string Description { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
}
