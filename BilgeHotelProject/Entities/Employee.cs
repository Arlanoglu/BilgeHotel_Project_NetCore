using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public bool IsActive { get; set; }
        public decimal HourlyRate { get; set; }
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LeavingWorkDate { get; set; }
        public string ReasonForLeaving { get; set; }

        public Guid DepartmentID { get; set; }
        public Guid ShiftID { get; set; }
        public Guid EmployeeStatuID { get; set; }
        public Guid UserID { get; set; }
        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual EmployeeStatu EmployeeStatu { get; set; }
        //Todo: User nasıl eklenecek araştırılacak. IdentityUser
    }
}
