using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Employee
{
    public class VMEmployeeUpdate
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Görev boş bırakılamaz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Kimlik no boş bırakılamaz.")]
        public string IdentificationNumber { get; set; }
        [Required(ErrorMessage = "İsim boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email boş bırakılamaz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon no boş bırakılamaz.")]
        public string PhoneNumber { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal OvertimePay { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public int ShiftID { get; set; }
        public int DepartmentID { get; set; }
    }
}
