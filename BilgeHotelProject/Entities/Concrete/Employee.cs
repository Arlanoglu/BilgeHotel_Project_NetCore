using Core.Entities;
using Entities.Enum;
using System;

namespace Entities.Concrete
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public bool IsActive { get; set; }
        public decimal HourlyRate { get; set; }
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? LeavingWorkDate { get; set; }
        public string ReasonForLeaving { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }

        public int DepartmentID { get; set; }
        public int ShiftID { get; set; }
        public int UserID { get; set; }
        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
