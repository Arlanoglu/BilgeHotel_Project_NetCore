using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Employee;
using WebUI.Models.Salary;
using Core.Entities.Enum;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [Authorize(Roles = "muhasebe")]
    public class SalaryController : Controller
    {
        private readonly IMapper mapper;
        private readonly ISalaryService salaryService;
        private readonly IEmployeeService employeeService;
        private readonly IResult result;
        private readonly IWorkScheduleService workScheduleService;

        public SalaryController(IMapper mapper, ISalaryService salaryService, IEmployeeService employeeService, IResult result, IWorkScheduleService workScheduleService)
        {
            this.mapper = mapper;
            this.salaryService = salaryService;
            this.employeeService = employeeService;
            this.result = result;
            this.workScheduleService = workScheduleService;
        }
        public async Task<IActionResult> PaidSalaries()
        {
            if (TempData["SalaryResult"] != null)
            {
                var salaryResult = JsonConvert.DeserializeObject<Result>(TempData["SalaryResult"].ToString());
                ViewBag.SalaryResult = salaryResult;
            }

            var salaries = (await salaryService.GetActive()).Where(x => x.BeenPaid == true).ToList();
            var vmSalaries = mapper.Map<List<VMSalary>>(salaries);

            var employees = await employeeService.GetActive();
            ViewBag.Employees = mapper.Map<List<VMEmployeeList>>(employees);

            return View(vmSalaries);
        }
        public async Task<IActionResult> UnPaidSalaries()
        {
            if (TempData["SalaryResult"] != null)
            {
                var salaryResult = JsonConvert.DeserializeObject<Result>(TempData["SalaryResult"].ToString());
                ViewBag.SalaryResult = salaryResult;
            }

            var salaries = (await salaryService.GetActive()).Where(x => x.BeenPaid == false).ToList();
            var vmSalaries = mapper.Map<List<VMSalary>>(salaries);

            var employees = await employeeService.GetActive();
            ViewBag.Employees = mapper.Map<List<VMEmployeeList>>(employees);

            return View(vmSalaries);
        }
        [HttpPost]
        public async Task<IActionResult> CalculateSalary(int month, int year, int employeeId)
        {

            if (month >= 1 && month <= 12 && year >= 2022)
            {
                if (await salaryService.Any(x=>x.Month == month && x.Year == year && x.EmployeeID==employeeId && x.Status == Status.Active))
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = $"{month}. Ay {year} Yılına ait {employeeId} id numaralı çalışanın maaşı zaten kaydedilmiş.";
                    TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
                }
                else
                {
                    var workSchedules = await workScheduleService.GetDefault(x => x.Date.Month == month && x.Date.Year == year && x.EmployeeID == employeeId && x.Status == Status.Active);

                    Salary salary = new Salary();
                    salary.MonthlySalary = salaryService.CalculateSalary(workSchedules);
                    salary.Month = month;
                    salary.Year = year;
                    salary.EmployeeID = employeeId;

                    var createResult = salaryService.Create(salary);
                    TempData["SalaryResult"] = JsonConvert.SerializeObject(createResult);
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Giriş bilgileri hatalı. Lütfen ay ve yıl bilgilerini kontrol edip tekrar deneyin.";
                TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("UnPaidSalaries");
        }

        //Todo : Toplu maaş hesaplama işlemi yapılabilir.
        //[HttpPost]
        //public async Task<IActionResult> CalculateAllSalary(int month, int year)
        //{

        //    if (month >= 1 && month <= 12 && year >= 2022)
        //    {
        //        var workSchedules = await workScheduleService.GetDefault(x => x.Date.Month == month && x.Date.Year == year && x.Status == Status.Active);
        //        var salaries = (await salaryService.GetActive()).Where(x => x.Month == month && x.Year == year).ToList();

        //        var query = workSchedules.Where(x => salaries.Any(w => x.EmployeeID == w.EmployeeID) == false).ToList();

        //        var sonuc = from q in query
        //                    group q by q.EmployeeID into Grup
        //                    select 
                            


        //        if (await salaryService.Any(x => x.Month == month && x.Year == year && x.EmployeeID == employeeId && x.Status == Status.Active))
        //        {
        //            result.ResultStatus = ResultStatus.Error;
        //            result.Message = $"{month}. Ay {year} Yılına ait {employeeId} id numaralı çalışanın maaşı zaten kaydedilmiş.";
        //            TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
        //        }
        //        else
        //        {
        //            var workSchedules = await workScheduleService.GetDefault(x => x.Date.Month == month && x.Date.Year == year && x.EmployeeID == employeeId && x.Status == Status.Active);

        //            Salary salary = new Salary();
        //            salary.MonthlySalary = salaryService.CalculateSalary(workSchedules);
        //            salary.Month = month;
        //            salary.Year = year;
        //            salary.EmployeeID = employeeId;

        //            var createResult = salaryService.Create(salary);
        //            TempData["SalaryResult"] = JsonConvert.SerializeObject(createResult);
        //        }
        //    }
        //    else
        //    {
        //        result.ResultStatus = ResultStatus.Error;
        //        result.Message = "Giriş bilgileri hatalı. Lütfen ay ve yıl bilgilerini kontrol edip tekrar deneyin.";
        //        TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
        //    }

        //    return RedirectToAction("UnPaidSalaries");
        //}

        public async Task<IActionResult> DeletedSalaries()
        {
            if (TempData["SalaryResult"] != null)
            {
                var salaryResult = JsonConvert.DeserializeObject<Result>(TempData["SalaryResult"].ToString());
                ViewBag.SalaryResult = salaryResult;
            }

            var salaries = await salaryService.GetDefault(x => x.Status == Status.Deleted);
            var vmSalaries = mapper.Map<List<VMSalary>>(salaries);

            return View(vmSalaries);
        }
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var salary = await salaryService.GetById(id);
            if (salary != null)
            {
                if (salary.Status == Status.Active)
                {
                    salary.Status = Status.Deleted;
                }
                else
                {
                    if (await salaryService.Any(x => x.Month == salary.Month && x.Year == salary.Year && x.EmployeeID == salary.EmployeeID && x.Status == Status.Active))
                    {
                        result.ResultStatus = ResultStatus.Error;
                        result.Message = $"{salary.Month}. Ay {salary.Year} Yılına ait {salary.EmployeeID} id numaralı çalışanın maaşı zaten kaydedilmiş.";
                        TempData["SalaryResult"] = JsonConvert.SerializeObject(result);

                        return RedirectToAction("PaidSalaries");
                    }
                    else
                    {
                        salary.Status = Status.Active;
                    }
                }
                var updateResult = salaryService.Update(salary);
                TempData["SalaryResult"] = JsonConvert.SerializeObject(updateResult);
                
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("PaidSalaries");

        }
        public async Task<IActionResult> PaySalary(int id)
        {
            var salary = await salaryService.GetById(id);
            if (salary != null)
            {
                salary.BeenPaid = true;
                salary.PaymentDate = DateTime.Now;

                var updateResult = salaryService.Update(salary);
                TempData["SalaryResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("UnPaidSalaries");
        }

        public async Task<IActionResult> RemoveForce(int id)
        {
            if (await salaryService.Any(x => x.ID == id))
            {
                var deleteResult = salaryService.RemoveForce(id);
                TempData["SalaryResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["SalaryResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("DeletedSalaries");
        }

    }
}
