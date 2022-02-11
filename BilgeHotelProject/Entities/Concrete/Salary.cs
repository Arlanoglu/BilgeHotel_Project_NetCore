using Core.Entities;

namespace Entities.Concrete
{
    public class Salary : BaseEntity
    {
        public decimal MounthlySalary { get; set; }
        public bool BeenPaid { get; set; }
        public string Description { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
