using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Salary : BaseEntity
    {
        public decimal MonthlySalary { get; set; }
        public bool BeenPaid { get; set; }
        public string Description { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime? PaymentDate { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
