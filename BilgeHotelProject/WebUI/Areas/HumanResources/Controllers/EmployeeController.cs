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
using Microsoft.AspNetCore.Identity;
using WebUI.Models.Department;
using WebUI.Models.Shift;
using Entities.Enum;
using System.Globalization;

namespace WebUI.Areas.HumanResources.Controllers
{
    [Area("HumanResources")]
    public class EmployeeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IEmployeeService employeeService;
        private readonly IResult result;
        private readonly IShiftService shiftService;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IDepartmentService departmentService;
        private readonly SignInManager<AppUser> signInManager;

        public EmployeeController(IMapper mapper, IEmployeeService employeeService, IResult result, IShiftService shiftService, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IDepartmentService departmentService, SignInManager<AppUser> signInManager)
        {
            this.mapper = mapper;
            this.employeeService = employeeService;
            this.result = result;
            this.shiftService = shiftService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.departmentService = departmentService;
            this.signInManager = signInManager;
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
        public async Task<IActionResult> ExEmployees()
        {
            if (TempData["EmployeeResult"] != null)
            {
                var employeeResultResult = JsonConvert.DeserializeObject<Result>(TempData["EmployeeResult"].ToString());
                ViewBag.EmployeeResult = employeeResultResult;
            }
            var employees = await employeeService.GetDefault(x=>x.IsActive==false);
            var vmEmployees = mapper.Map<List<VMEmployeeList>>(employees);
            return View(vmEmployees);
        }
        public async Task<IActionResult> DeleteEmployee(int id)        
        {
            var employee = await employeeService.GetById(id);
            if (employee!=null)
            {
                var vmEmployee = mapper.Map<VMEmployeeDelete>(employee);
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
        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(VMEmployeeDelete vMEmployeeDelete)
        {
            if (ModelState.IsValid)
            {
                var employee = await employeeService.GetById(vMEmployeeDelete.ID);
                var user = await userManager.FindByIdAsync(employee.UserID);
                if (employee != null)
                {
                    if (user != null)
                    {
                        await userManager.DeleteAsync(user); 
                    }
                    employee.IsActive = false;
                    employee.LeavingWorkDate = vMEmployeeDelete.LeavingWorkDate;
                    employee.ReasonForLeaving = vMEmployeeDelete.ReasonForLeaving;
                    employee.Status = Status.Deleted;
                    var updateResult = employeeService.Update(employee);

                    TempData["EmployeeResult"] = JsonConvert.SerializeObject(updateResult);
                    return RedirectToAction("EmployeeDetail", new { id = vMEmployeeDelete.ID });
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "İlgili idye ait çalışan bulunamadı.";
                    TempData["EmployeeResult"] = JsonConvert.SerializeObject(result);

                    return RedirectToAction("Index");
                }

            }
            else
            {
                return View(vMEmployeeDelete);
            }

        }
        public async Task<IActionResult> CreateEmployee()
        {
            //Çalışan oluştururken dropdownlarda kullanılacak departman ve vardiya listeleri.
            var departments = await departmentService.GetActive();
            var vmDepartmets = mapper.Map<List<VMDepartmentSelectList>>(departments);

            var shifts = await shiftService.GetActive();
            var vmShifts = mapper.Map<List<VMShiftSelectList>>(shifts);
            var roles = roleManager.Roles.Select(x => x.Name).ToArray();

            TempData["Departments"] = JsonConvert.SerializeObject(vmDepartmets);
            TempData["Shifts"] = JsonConvert.SerializeObject(vmShifts);
            TempData["Roles"] = roles;
            ViewBag.Departments = departments;
            ViewBag.Shifts = shifts;
            ViewBag.Roles = roles;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(VMEmployeeCreate vMEmployeeCreate)
        {
            if (ModelState.IsValid)
            {
                if (await employeeService.Any(x=>x.IdentificationNumber==vMEmployeeCreate.IdentificationNumber))
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Kaydetmek istediğiniz çalışan sistemde zaten kayıtlı. İşten ayrılan çalışanlar listeni kontrol edip, ilgili alandan çalışanı aktif hale getirebilirsiniz.";
                    ViewBag.EmployeeResult = result;
                }
                else
                {
                    //İşlem yapan kişi admin olmadığı sürece admin yetkisi atayamaz.
                    if ((User.IsInRole("admin") && vMEmployeeCreate.UserRole=="admin") || vMEmployeeCreate.UserRole!="admin")
                    {
                        var user = mapper.Map<AppUser>(vMEmployeeCreate);
                        user.UserName = vMEmployeeCreate.Email;
                        user.EmailConfirmed = true;
                        var result = await userManager.CreateAsync(user, $"{vMEmployeeCreate.FirstName}.123");
                        if (result.Succeeded)
                        {
                            var roleResult = await userManager.AddToRoleAsync(user, vMEmployeeCreate.UserRole);
                            vMEmployeeCreate.UserID = (await userManager.FindByEmailAsync(vMEmployeeCreate.Email)).Id;
                        }

                        var employee = mapper.Map<Employee>(vMEmployeeCreate);
                        var createResult = employeeService.Create(employee);

                        TempData["EmployeeResult"] = JsonConvert.SerializeObject(createResult);

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        result.ResultStatus = ResultStatus.Error;
                        result.Message = "Admin rolünü atamak için yetkiniz bulunmamaktadır.";
                        ViewBag.EmployeeResult = result;
                    }
                }

                
            }

            ViewBag.Departments = JsonConvert.DeserializeObject<List<VMDepartmentSelectList>>(TempData["Departments"].ToString());
            TempData.Keep("Departments");
            ViewBag.Shifts = JsonConvert.DeserializeObject<List<VMShiftSelectList>>(TempData["Shifts"].ToString());
            TempData.Keep("Shifts");
            ViewBag.Roles = TempData["Roles"];
            TempData.Keep("Roles");
            var test = Enum.GetValues(typeof(EmployeeStatus));
            return View();
        }

    }
}
                                          