using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Entities.Enum;

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
                    new Department { ID = 3, DepartmentName = "Mutfak" },
                    new Department { ID = 4, DepartmentName = "Resepsiyon" },
                    new Department { ID = 5, DepartmentName = "Yönetim" },
                    new Department { ID = 6, DepartmentName = "İnsan Kaynakları" }
                );
            #endregion

            #region EmployeeData
            List<Employee> employees = new List<Employee>();

            void FakeEmployee(string title, int departmentId, EmployeeStatus status)
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
                emp.ID = employees.Count + 1; emp.Title = title; emp.EmployeeStatus = status; emp.DepartmentID = departmentId; emp.IsActive = true;
                employees.Add(emp);
            }

            for (int i = 1; i <= 7; i++)
            {
                FakeEmployee("Resepsiyonist", 4, EmployeeStatus.Worker);
            }
            for (int i = 1; i <= 11; i++)
            {
                FakeEmployee("Temizlik Görevlisi", 1, EmployeeStatus.Worker);
            }
            for (int i = 1; i <= 11; i++)
            {
                FakeEmployee("Aşçı", 3, EmployeeStatus.Worker);
            }
            for (int i = 1; i <= 13; i++)
            {
                FakeEmployee("Garson", 3, EmployeeStatus.Worker);
            }

            FakeEmployee("Elektirikçi", 1, EmployeeStatus.Worker);
            FakeEmployee("Elektirikçi", 2, EmployeeStatus.Worker);

            builder.Entity<Employee>().HasData(employees);
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
            //builder.Entity<Entities.Concrete.Shift>().HasData(
            //    //Reception
            //        new Entities.Concrete.Shift { WeekNumber="W1", Date= DateTime.Parse("2022-03-14"), IsHoliday=true, Holiday= Holiday.Off, Shift= Entities.Enum.Shift.MorningShift, EmployeeID=1 },
            //        );
            #endregion
        }
    }
}
