using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public static class FakeData
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region DepartmentData
            builder.Entity<Department>().HasData(
                    new Department { ID = 1, DepartmentName = "Yardımcı Hizmetler" },
                    new Department { ID = 2, DepartmentName = "Bilgi İşlem" },
                    new Department { ID = 3, DepartmentName = "Yönetim" },
                    new Department { ID = 4, DepartmentName = "Resepsiyon" },
                    new Department { ID = 5, DepartmentName = "Mutfak" },
                    new Department { ID = 6, DepartmentName = "İnsan Kaynakları" }
                );
            #endregion
                        
            #region SalaryData
            builder.Entity<Salary>().HasData(
                    new Salary { ID = 1, EmployeeID = 1, MonthlySalary = 5000, BeenPaid = true, Month = "Şubat", PaymentDate = DateTime.Parse("2022-03-05") },
                    new Salary { ID = 2, EmployeeID = 2, MonthlySalary = 5500, BeenPaid = true, Month = "Şubat", PaymentDate = DateTime.Parse("2022-03-05") },
                    new Salary { ID = 1, EmployeeID = 1, MonthlySalary = 5000, BeenPaid = false, Month = "Mart" },
                    new Salary { ID = 2, EmployeeID = 2, MonthlySalary = 5500, BeenPaid = false, Month = "Mart" }
                    );
            #endregion

            #region ShiftData
            builder.Entity<ShiftPlan>().HasData(
                    new ShiftPlan { ID = 1, ShiftName = "Gündüz", StartTime = TimeSpan.FromHours(08), EndTime = TimeSpan.FromHours(16), Description = "Bu vardiya 8:00 da başlayacak 16:00 da bitecektir." },
                    new ShiftPlan { ID = 2, ShiftName = "Akşam", StartTime = TimeSpan.FromHours(16), EndTime = TimeSpan.FromHours(00), Description = "Bu vardiya 16:00 da başlayacak 00:00 da bitecektir." },
                    new ShiftPlan { ID = 3, ShiftName = "Gece", StartTime = TimeSpan.FromHours(00), EndTime = TimeSpan.FromHours(08), Description = "Bu vardiya 00:00 da başlayacak 08:00 da bitecektir." }
                    );
            #endregion

            #region EmployeeData
            //builder.Entity<Employee>().HasData(
            //    new Employee { ID = 1, Title = "Resepsiyonist", FirstName = "Fatma", LastName = "Acar", StartDateOfWork = DateTime.Parse("2022-09-08"), HourlyRate = 192, IdentificationNumber = "00000000001", Email = "fatma.acar@gmail.com", PhoneNumber = "05450000001", EmployeeStatus = Entities.Enum.EmployeeStatus.Worker, DepartmentID = 4, ShiftID =, IsActive = true }
            //    );

            List<Employee> employees = new List<Employee>();

            #region Reception
            void FakeEmployee(string title,int departmentId, int shiftID)
            {
                var employee = new Faker<Employee>()
                    .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                    .RuleFor(x => x.LastName, x => x.Person.LastName)
                    .RuleFor(x => x.StartDateOfWork, x => x.Date.Between(DateTime.Parse("2019-01-01"), DateTime.Now))
                    .RuleFor(x => x.HourlyRate, x => x.Random.Decimal(190, 200))
                    .RuleFor(x => x.IdentificationNumber, x => x.Random.ULong(111111111111, 999999999999).ToString())
                    .RuleFor(x => x.Email, x => x.Person.Email)
                    .RuleFor(x => x.PhoneNumber, x => x.Person.Phone);
                Employee emp = employee;
                emp.ID = employees.Count+1; emp.Title = title; emp.EmployeeStatus = Entities.Enum.EmployeeStatus.Worker; emp.DepartmentID = departmentId; emp.IsActive = true;
                employees.Add(emp);
            }
            
            //1. employee off günü
            FakeEmployee("Resepsiyonist",4,4);
            for (int i = 1; i <= 2; i++)
            {
                var employee = new Faker<Employee>()
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName)
                .RuleFor(x => x.StartDateOfWork, x => x.Date.Between(DateTime.Parse("2019-01-01"), DateTime.Now))
                .RuleFor(x => x.HourlyRate, x => x.Random.Decimal(190, 200))
                .RuleFor(x => x.IdentificationNumber, x => x.Random.ULong(111111111111, 999999999999).ToString())
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone);
                Employee emp = employee1;
                emp1.ID = employees.Count + 1; emp.Title = "Resepsiyonist"; emp.EmployeeStatus = Entities.Enum.EmployeeStatus.Worker; emp.DepartmentID = 4; emp.ShiftID = 1; emp.IsActive = true;
                employees.Add(emp);
            }
            for (int i = 1; i <= 2; i++)
            {
                var employee = new Faker<Employee>()
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName)
                .RuleFor(x => x.StartDateOfWork, x => x.Date.Between(DateTime.Parse("2019-01-01"), DateTime.Now))
                .RuleFor(x => x.HourlyRate, x => x.Random.Decimal(190, 200))
                .RuleFor(x => x.IdentificationNumber, x => x.Random.ULong(111111111111, 999999999999).ToString())
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone);
                Employee emp = employee1;
                emp1.ID = employees.Count + 1; emp.Title = "Resepsiyonist"; emp.EmployeeStatus = Entities.Enum.EmployeeStatus.Worker; emp.DepartmentID = 4; emp.ShiftID = 2; emp.IsActive = true;
                employees.Add(emp);
            }
            for (int i = 1; i <= 2; i++)
            {
                var employee = new Faker<Employee>()
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName)
                .RuleFor(x => x.StartDateOfWork, x => x.Date.Between(DateTime.Parse("2019-01-01"), DateTime.Now))
                .RuleFor(x => x.HourlyRate, x => x.Random.Decimal(190, 200))
                .RuleFor(x => x.IdentificationNumber, x => x.Random.ULong(111111111111, 999999999999).ToString())
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone);
                Employee emp = employee1;
                emp1.ID = employees.Count + 1; emp.Title = "Resepsiyonist"; emp.EmployeeStatus = Entities.Enum.EmployeeStatus.Worker; emp.DepartmentID = 4; emp.ShiftID = 3; emp.IsActive = true;
                employees.Add(emp);
            }
            #endregion

            #region CleaningStaff

            #endregion

            builder.Entity<Employee>().HasData(employees);
            #endregion
        }
    }
}
