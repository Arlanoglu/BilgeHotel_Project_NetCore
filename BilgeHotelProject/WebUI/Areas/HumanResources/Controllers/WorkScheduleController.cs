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
using WebUI.Models.WorkSchedule;
using Core.Entities.Enum;
using Entities.Concrete;
using WebUI.Models.Employee;

namespace WebUI.Areas.HumanResources.Controllers
{
    [Area("HumanResources")]
    public class WorkScheduleController : Controller
    {
        private readonly IMapper mapper;
        private readonly IWorkScheduleService workScheduleService;
        private readonly IResult result;
        private readonly IEmployeeService employeeService;
        private readonly ISalaryService salaryService;

        public WorkScheduleController(IMapper mapper, IWorkScheduleService workScheduleService, IResult result, IEmployeeService employeeService, ISalaryService salaryService)
        {
            this.mapper = mapper;
            this.workScheduleService = workScheduleService;
            this.result = result;
            this.employeeService = employeeService;
            this.salaryService = salaryService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["WorkScheduleResult"] != null)
            {
                var workScheduleResult = JsonConvert.DeserializeObject<Result>(TempData["WorkScheduleResult"].ToString());
                ViewBag.WorkScheduleResult = workScheduleResult;
            }
            var workSchedules = await workScheduleService.GetAll();
            var vmWorkSchedules = mapper.Map<List<VMWorkScheduleList>>(workSchedules);    

            return View(vmWorkSchedules);
        }
        public async Task<IActionResult> WorkScheduleDetail(int id)
        {
            if (TempData["WorkScheduleResult"] != null)
            {
                var workScheduleResult = JsonConvert.DeserializeObject<Result>(TempData["WorkScheduleResult"].ToString());
                ViewBag.WorkScheduleResult = workScheduleResult;
            }
            var workSchedule = await workScheduleService.GetById(id);
            if (workSchedule != null)
            {
                var vmWorkSchedule = mapper.Map<VMWorkScheduleDetail>(workSchedule);

                return View(vmWorkSchedule);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }        
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var workSchedule = await workScheduleService.GetById(id);
            if (workSchedule != null)
            {
                if (workSchedule.Status == Status.Active)
                {
                    workSchedule.Status = Status.Deleted;
                }
                else if (workSchedule.Status == Status.Deleted)
                {
                    workSchedule.Status = Status.Active;
                }
                var updateResult = workScheduleService.Update(workSchedule);
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(result);                
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ActiveWorkSchedules()
        {
            if (TempData["WorkScheduleResult"] != null)
            {
                var workScheduleResult = JsonConvert.DeserializeObject<Result>(TempData["WorkScheduleResult"].ToString());
                ViewBag.WorkScheduleResult = workScheduleResult;
            }
            var workSchedules = await workScheduleService.GetActive();
            var vmWorkSchedules = mapper.Map<List<VMWorkScheduleList>>(workSchedules);

            return View(vmWorkSchedules);
        }
        public async Task<IActionResult> CreateWorkSchedule()
        {
            if (TempData["WorkScheduleResult"] != null)
            {
                var workScheduleResult = JsonConvert.DeserializeObject<Result>(TempData["WorkScheduleResult"].ToString());
                ViewBag.WorkScheduleResult = workScheduleResult;
            }
            var employees = await employeeService.GetActive();
            var vmWorkScheduleCreateList = mapper.Map<List<VMWorkScheduleCreate>>(employees);

            return View(vmWorkScheduleCreateList);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWorkSchedule(List<VMWorkScheduleCreate> vMWorkScheduleCreateList)
        {
            var workScheduleList = mapper.Map<List<WorkSchedule>>(vMWorkScheduleCreateList);
            var workschedules = await workScheduleService.GetActive();

            var query = workScheduleList.Where(x => workschedules.Any(w => x.Date == w.Date && x.EmployeeID == w.EmployeeID)==false).ToList();

            if (query.Count > 0)
            {
                var createResult = workScheduleService.CreateList(query);

                ViewBag.WorkScheduleResult = createResult;

                if (createResult.ResultStatus == ResultStatus.Success)
                {
                    TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(createResult);
                    return RedirectToAction("Index");
                }

                return View(vMWorkScheduleCreateList);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Bir çalışan için aynı tarihe iki veya daha fazla kayıt yapılamaz. Kaydetmek istediğiniz çalışanlara ait ilgili tarihlerde kayıt gözüküyor. Lütfen var olan kayıtları kontrol ediniz.";
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }           

            
        }
        public async Task<IActionResult> SingularCreateWorkSchedule()
        {
            if (TempData["WorkScheduleResult"] != null)
            {
                var workScheduleResult = JsonConvert.DeserializeObject<Result>(TempData["WorkScheduleResult"].ToString());
                ViewBag.WorkScheduleResult = workScheduleResult;
            }
            var employees = await employeeService.GetActive();
            var vmEmployees = mapper.Map<List<VMEmployeeList>>(employees);
            ViewBag.Employees = vmEmployees;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingularCreateWorkSchedule(VMWorkScheduleCreate vMWorkScheduleCreate)
        {

            var employee = await employeeService.GetById(vMWorkScheduleCreate.EmployeeID);
            vMWorkScheduleCreate.ShiftName = employee.Shift.ShiftName;
            vMWorkScheduleCreate.ShiftStartTime = employee.Shift.StartTime;
            vMWorkScheduleCreate.ShiftEndTime = employee.Shift.EndTime;
            var workSchedule = mapper.Map<WorkSchedule>(vMWorkScheduleCreate);

            if (await workScheduleService.Any(x=>x.EmployeeID==vMWorkScheduleCreate.EmployeeID && x.Date==vMWorkScheduleCreate.Date.Date && x.Status==Status.Active))
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Bir çalışan için aynı tarihe iki veya daha fazla kayıt yapılamaz. Kaydetmek istediğiniz çalışana ait ilgili tarihte kayıt gözüküyor. Lütfen var olan kayıtları kontrol ediniz.";
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }

            var createResult = workScheduleService.Create(workSchedule);
            ViewBag.WorkScheduleResult = createResult;

            if (createResult.ResultStatus == ResultStatus.Success)
            {
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(createResult);
                return RedirectToAction("Index");
            }

            var employees = await employeeService.GetActive();
            var vmEmployees = mapper.Map<VMEmployeeList>(employees);
            ViewBag.Employees = vmEmployees;
            return View(vMWorkScheduleCreate);
        }
        public async Task<IActionResult> UpdateWorkSchedule(int id)
        {
            var workSchedule = await workScheduleService.GetById(id);

            if (workSchedule != null)
            {
                var vmWorkSchedule = mapper.Map<VMWorkScheduleUpdate>(workSchedule);
                return View(vmWorkSchedule);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Kayıt bulunamadı.";
                TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public async Task<IActionResult> UpdateWorkSchedule(VMWorkScheduleUpdate vMWorkScheduleUpdate)
        {
            var workSchedule = await workScheduleService.GetById(vMWorkScheduleUpdate.WorkScheduleID);
            workSchedule.Date = vMWorkScheduleUpdate.Date;
            workSchedule.TotalWorkTime = vMWorkScheduleUpdate.TotalWorkTime;
            workSchedule.TimesWorked = vMWorkScheduleUpdate.TimesWorked;
            workSchedule.HaveOverTime = vMWorkScheduleUpdate.HaveOverTime;
            workSchedule.OverTimeHour = vMWorkScheduleUpdate.OverTimeHour;
            workSchedule.WorkStatus = vMWorkScheduleUpdate.WorkStatus;
            workSchedule.Description = vMWorkScheduleUpdate.Description;

            var updateResult = workScheduleService.Update(workSchedule);
            ViewBag.WorkScheduleResult = updateResult;

            return View(vMWorkScheduleUpdate);
        }
    }
}
