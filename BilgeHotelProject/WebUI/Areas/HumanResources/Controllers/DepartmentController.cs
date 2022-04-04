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
using WebUI.Models.Department;
using Core.Entities.Enum;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Areas.HumanResources.Controllers
{
    [Area("HumanResources")]
    [Authorize(Roles = "insan kaynaklari")]
    public class DepartmentController : Controller
    {
        private readonly IMapper mapper;
        private readonly IDepartmentService departmentService;
        private readonly IResult result;
        private readonly IEmployeeService employeeService;

        public DepartmentController(IMapper mapper, IDepartmentService departmentService, IResult result, IEmployeeService employeeService)
        {
            this.mapper = mapper;
            this.departmentService = departmentService;
            this.result = result;
            this.employeeService = employeeService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["DepartmentResult"] != null)
            {
                var departmentResultResult = JsonConvert.DeserializeObject<Result>(TempData["DepartmentResult"].ToString());
                ViewBag.DepartmentResult = departmentResultResult;
            }
            var departments = await departmentService.GetAll();
            var vmDepartments = mapper.Map<List<VMDepartmentList>>(departments);
            return View(vmDepartments);
        }
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var department = await departmentService.GetById(id);
            if (department!=null)
            {
                if (department.Status==Status.Active)
                {
                    if (await employeeService.Any(x => x.DepartmentID == id))
                    {
                        result.ResultStatus = ResultStatus.Error;
                        result.Message = "Bir veya birden fazla çalışan silmek istediğiniz departmanda çalışıyor görünmekte. Bu departmanın durumunu değiştirmek için öncelikle departmanda çalışan olmadığından emin olun.";
                        TempData["DepartmentResult"] = JsonConvert.SerializeObject(result);
                        return RedirectToAction("Index");
                    }
                    department.Status = Status.Deleted;
                }
                else if (department.Status == Status.Deleted)
                {                    
                    department.Status = Status.Active;
                }
                var updateResult = departmentService.Update(department);
                TempData["DepartmentResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait departman bulunamadı.";
                TempData["DepartmentResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveForce(int id)
        {
            var department = await departmentService.GetById(id);
            if (department != null)
            {
                if (await employeeService.Any(x => x.DepartmentID == id))
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Bir veya birden fazla çalışan silmek istediğiniz departmanda çalışıyor görünmekte. Bu departmanın durumunu değiştirmek için öncelikle departmanda çalışan olmadığından emin olun.";
                    TempData["DepartmentResult"] = JsonConvert.SerializeObject(result);
                    return RedirectToAction("Index");
                }

                var deleteResult = departmentService.RemoveForce(id);
                TempData["DepartmentResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait departman bulunamadı.";
                TempData["DepartmentResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateDepartment(int id)
        {
            var department = await departmentService.GetById(id);
            if (department != null)
            {
                var vmDepartment = mapper.Map<VMDepartmentUpdate>(department);
                return View(vmDepartment);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait departman bulunamadı.";
                TempData["DepartmentResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDepartment(VMDepartmentUpdate vMDepartmentUpdate)
        {
            if (ModelState.IsValid)
            {
                var department = await departmentService.GetById(vMDepartmentUpdate.ID);
                department.DepartmentName = vMDepartmentUpdate.DepartmentName;
                department.Description = vMDepartmentUpdate.Description;
                var updateResult = departmentService.Update(department);

                TempData["DepartmentResult"] = JsonConvert.SerializeObject(updateResult);

                return RedirectToAction("Index");
            }
            else
            {
                return View(vMDepartmentUpdate);
            }
        }
        public IActionResult CreateDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDepartment(VMDepartmentCreate vMDepartmentCreate)
        {
            if (ModelState.IsValid)
            {
                var department = mapper.Map<Department>(vMDepartmentCreate);
                var createResult = departmentService.Create(department);

                TempData["DepartmentResult"] = JsonConvert.SerializeObject(createResult);

                return RedirectToAction("Index");
            }
            else
            {
                return View(vMDepartmentCreate);
            }
        }
    }
}
