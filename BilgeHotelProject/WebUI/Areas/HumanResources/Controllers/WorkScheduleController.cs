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
        public IActionResult CreateWorkSchedule(List<VMWorkScheduleCreate> vMWorkScheduleCreateList)
        {
            var workScheduleList = mapper.Map<List<WorkSchedule>>(vMWorkScheduleCreateList);

            var createResult = workScheduleService.CreateList(workScheduleList);

            TempData["WorkScheduleResult"] = JsonConvert.SerializeObject(createResult);
            if (createResult.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("Index");
            }

            return View(vMWorkScheduleCreateList);
        }
    }
}
