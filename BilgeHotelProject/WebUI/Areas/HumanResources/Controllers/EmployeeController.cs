using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Employee;
using WebUI.Utilities;
using WebUI.Utilities.Enums;
using Core.Entities.Enum;

namespace WebUI.Areas.HumanResources.Controllers
{
    [Area("HumanResources")]
    public class EmployeeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IEmployeeService employeeService;
        private readonly IResult result;
        private readonly IShiftService shiftService;

        public EmployeeController(IMapper mapper, IEmployeeService employeeService, IResult result, IShiftService shiftService)
        {
            this.mapper = mapper;
            this.employeeService = employeeService;
            this.result = result;
            this.shiftService = shiftService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["EmployeeResult"] != null)
            {
                var employeeResultResult = JsonConvert.DeserializeObject<Result>(TempData["EmployeeResult"].ToString());
                ViewBag.EmployeeResult = employeeResultResult;
            }
            var employees = await employeeService.GetActive();
            var vmEmployees = mapper.Map<List<VMEmployeeList>>(employees);
            return View(vmEmployees);
        }
        public async Task<IActionResult> EmployeeDetail(int id)
        {
            var employee = await employeeService.GetById(id);
            if (employee!=null)
            {
                var vmEmployee = mapper.Map<VMEmployeeDetail>(employee);
                return View(vmEmployee);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait çalışan bulunamadı.";
                TempData["EmployeeResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("Index");
            }
            
        }
        public async Task<IActionResult> AddShiftToEmployee(int shiftId, string shiftName)
        {
            if (await shiftService.Any(x=>x.ID==shiftId && x.Status==Status.Active))
            {
                ObjectCreator creator = new ObjectCreator();
                var vmAddshiftToEmployee = (VMAddShiftToEmployeeCombine)creator.FactoryMethod(ViewModels.VMAddShiftToEmployeeCombine);

                var employees = await employeeService.GetActive();
                vmAddshiftToEmployee.Employees = mapper.Map<List<VMAddShiftToEmployee>>(employees);
                vmAddshiftToEmployee.ShiftID = shiftId;
                vmAddshiftToEmployee.ShiftName = shiftName;
                return View(vmAddshiftToEmployee);
            }
            return RedirectToAction("Index", "Shift");
        }
        [HttpPost]
        public async Task<IActionResult> AddShiftToEmployee(VMAddShiftToEmployeeCombine vMAddShiftToEmployeeCombine)
        {
            var filterList = vMAddShiftToEmployeeCombine.Employees.Where(x => x.Selected == true).ToList();
            var employees = await employeeService.GetActive();

            var query = from f in filterList
                        join e in employees on f.ID equals e.ID
                        select e;
            foreach (var item in query.ToList())
            {
                item.ShiftID = vMAddShiftToEmployeeCombine.ShiftID;
            }
            var updateResult = employeeService.ListUpdate(query.ToList());

            TempData["ShiftResult"] = JsonConvert.SerializeObject(updateResult);
            return RedirectToAction("Index", "Shift");
        }
    }
}
