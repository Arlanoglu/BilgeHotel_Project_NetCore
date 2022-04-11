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
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Areas.HumanResources.Controllers
{
    [Area("HumanResources")]
    [Authorize(Roles = "insan kaynaklari")]
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
            if (TempData["EmployeeResult"] != null)
            {
                var employeeResultResult = JsonConvert.DeserializeObject<Result>(TempData["EmployeeResult"].ToString());
                ViewBag.EmployeeResult = employeeResultResult;
            }
            var employee = await employeeService.GetById(id);
            if (employee != null)
            {
                var user = await userManager.FindByEmailAsync(employee.Email);

                var vmEmployee = mapper.Map<VMEmployeeDetail>(employee);
                if (user != null)
                {
                    var roles = await userManager.GetRolesAsync(user);
                    vmEmployee.Roles = roles.ToArray();
                }
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
            if (await shiftService.Any(x => x.ID == shiftId && x.Status == Status.Active))
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
            var employees = await employeeService.GetDefault(x => x.IsActive == false);
            var vmEmployees = mapper.Map<List<VMEmployeeList>>(employees);
            return View(vmEmployees);
        }
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await employeeService.GetById(id);
            if (employee != null)
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
                //var user = await userManager.FindByIdAsync(employee.AppUserId);
                if (employee != null)
                {
                    if (employee.AppUser != null)
                    {
                        var roles = (await userManager.GetRolesAsync(employee.AppUser)).Where(x => x.Contains("user") == false).ToArray();
                        for (int i = 0; i < roles.Length; i++)
                        {
                            await userManager.RemoveFromRoleAsync(employee.AppUser, roles[i]);
                        }
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
                if (await employeeService.Any(x => x.IdentificationNumber == vMEmployeeCreate.IdentificationNumber))
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Kaydetmek istediğiniz çalışan sistemde zaten kayıtlı. İşten ayrılan çalışanlar listeni kontrol edip, ilgili alandan çalışanı aktif hale getirebilirsiniz.";
                    ViewBag.EmployeeResult = result;
                }
                else
                {
                    //İşlem yapan kişi admin olmadığı sürece admin yetkisi atayamaz.
                    if ((User.IsInRole("admin") && vMEmployeeCreate.UserRole == "admin") || vMEmployeeCreate.UserRole != "admin")
                    {
                        var userTest = await userManager.FindByEmailAsync(vMEmployeeCreate.Email);
                        if (userTest != null)
                        {
                            await userManager.AddToRoleAsync(userTest, vMEmployeeCreate.UserRole);
                            vMEmployeeCreate.AppUserId = (await userManager.FindByEmailAsync(vMEmployeeCreate.Email)).Id;
                        }
                        else
                        {
                            var user = mapper.Map<AppUser>(vMEmployeeCreate);
                            user.UserName = vMEmployeeCreate.Email;
                            user.EmailConfirmed = true;
                            user.CreatedDate = DateTime.Now;
                            var result = await userManager.CreateAsync(user, $"{vMEmployeeCreate.FirstName}.123");
                            if (result.Succeeded)
                            {
                                await userManager.AddToRoleAsync(user, vMEmployeeCreate.UserRole);
                                await userManager.AddToRoleAsync(user, "user");
                                vMEmployeeCreate.AppUserId = (await userManager.FindByEmailAsync(vMEmployeeCreate.Email)).Id;
                            }
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
            return View(vMEmployeeCreate);
        }
        public async Task<IActionResult> ActivateEmployee(int id)
        {
            #region Dropdownlar için kullanılacak veriler
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
            #endregion

            if (TempData["EmployeeResult"] != null)
            {
                var employeeResultResult = JsonConvert.DeserializeObject<Result>(TempData["EmployeeResult"].ToString());
                ViewBag.EmployeeResult = employeeResultResult;
            }
            var employee = await employeeService.GetById(id);
            if (employee.IsActive == false && employee != null)
            {
                var vmEmployee = mapper.Map<VMEmployeeActivate>(employee);
                return View(vmEmployee);
            }
            else if (employee.IsActive && employee != null)
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Çalışan zaten aktif gözüküyor.";
                TempData["EmployeeResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("EmployeeDetail", new { id = id });
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait çalışan kaydı bulunamadı.";
                TempData["EmployeeResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public async Task<IActionResult> ActivateEmployee(VMEmployeeActivate vMEmployeeActivate)
        {
            if (ModelState.IsValid)
            {
                //İşlem yapan kişi admin olmadığı sürece admin yetkisi atayamaz.
                if ((User.IsInRole("admin") && vMEmployeeActivate.UserRole == "admin") || vMEmployeeActivate.UserRole != "admin")
                {
                    var userQuery = await userManager.FindByEmailAsync(vMEmployeeActivate.Email);
                    if (userQuery == null)
                    {
                        var user = mapper.Map<AppUser>(vMEmployeeActivate);
                        user.UserName = vMEmployeeActivate.Email;
                        user.EmailConfirmed = true;
                        var result = await userManager.CreateAsync(user, $"{vMEmployeeActivate.FirstName}.123");
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(user, vMEmployeeActivate.UserRole);
                            await userManager.AddToRoleAsync(user, "user");
                            vMEmployeeActivate.AppUserId = (await userManager.FindByEmailAsync(vMEmployeeActivate.Email)).Id;
                        }
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(userQuery, vMEmployeeActivate.UserRole);
                        vMEmployeeActivate.AppUserId = userQuery.Id;
                    }

                    #region Entitynin propertylerinin güncellenmesi
                    var employee = await employeeService.GetById(vMEmployeeActivate.EmployeeID);
                    employee.Title = vMEmployeeActivate.Title;
                    employee.IdentificationNumber = vMEmployeeActivate.IdentificationNumber;
                    employee.FirstName = vMEmployeeActivate.FirstName;
                    employee.LastName = vMEmployeeActivate.LastName;
                    employee.Email = vMEmployeeActivate.Email;
                    employee.PhoneNumber = vMEmployeeActivate.PhoneNumber;
                    employee.StartDateOfWork = vMEmployeeActivate.StartDateOfWork;
                    employee.HourlyRate = vMEmployeeActivate.HourlyRate;
                    employee.MonthlySalary = vMEmployeeActivate.MonthlySalary;
                    employee.OvertimePay = vMEmployeeActivate.OvertimePay;
                    employee.EmployeeStatus = vMEmployeeActivate.EmployeeStatus;
                    employee.ShiftID = vMEmployeeActivate.ShiftID;
                    employee.DepartmentID = vMEmployeeActivate.DepartmentID;
                    employee.AppUserId = vMEmployeeActivate.AppUserId;
                    employee.Status = Status.Active;
                    employee.IsActive = true;
                    #endregion

                    var updateResult = employeeService.Update(employee);

                    TempData["EmployeeResult"] = JsonConvert.SerializeObject(updateResult);

                    if (updateResult.ResultStatus == ResultStatus.Success)
                    {
                        return RedirectToAction("EmployeeDetail", new { id = vMEmployeeActivate.EmployeeID });
                    }
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Admin rolünü atamak için yetkiniz bulunmamaktadır.";
                    ViewBag.EmployeeResult = result;
                }
            }
            ViewBag.Departments = JsonConvert.DeserializeObject<List<VMDepartmentSelectList>>(TempData["Departments"].ToString());
            TempData.Keep("Departments");
            ViewBag.Shifts = JsonConvert.DeserializeObject<List<VMShiftSelectList>>(TempData["Shifts"].ToString());
            TempData.Keep("Shifts");
            ViewBag.Roles = TempData["Roles"];
            TempData.Keep("Roles");

            return View(vMEmployeeActivate);
        }
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            #region Dropdownlar için kullanılacak veriler
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
            #endregion

            if (TempData["EmployeeResult"] != null)
            {
                var employeeResultResult = JsonConvert.DeserializeObject<Result>(TempData["EmployeeResult"].ToString());
                ViewBag.EmployeeResult = employeeResultResult;
            }
            var employee = await employeeService.GetById(id);
            if (employee != null && employee.IsActive)
            {
                var vmEmployee = mapper.Map<VMEmployeeUpdate>(employee);
                return View(vmEmployee);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait çalışan kaydı bulunamadı. Id yanlış olabilir yada çalışan İşten Ayrılan Çalışanlar listesinde kayıtlı olabilir. Bu durumda öncelikle çalışanı tekrar aktifleştirmeniz gerekmektedir.";
                TempData["EmployeeResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(VMEmployeeUpdate vMEmployeeUpdate)
        {
            if (ModelState.IsValid)
            {
                var employee = await employeeService.GetById(vMEmployeeUpdate.EmployeeID);

                IdentityResult identityResult = null;
                var user = await userManager.FindByEmailAsync(employee.Email);
                if (user != null && employee.Email != vMEmployeeUpdate.Email)
                {
                    user.Email = vMEmployeeUpdate.Email;
                    user.UserName = vMEmployeeUpdate.Email;
                    identityResult = await userManager.UpdateAsync(user);
                }

                #region Entitynin propertylerinin güncellenmesi

                employee.Title = vMEmployeeUpdate.Title;
                employee.IdentificationNumber = vMEmployeeUpdate.IdentificationNumber;
                employee.FirstName = vMEmployeeUpdate.FirstName;
                employee.LastName = vMEmployeeUpdate.LastName;
                employee.Email = vMEmployeeUpdate.Email;
                employee.PhoneNumber = vMEmployeeUpdate.PhoneNumber;
                employee.StartDateOfWork = vMEmployeeUpdate.StartDateOfWork;
                employee.HourlyRate = vMEmployeeUpdate.HourlyRate;
                employee.MonthlySalary = vMEmployeeUpdate.MonthlySalary;
                employee.OvertimePay = vMEmployeeUpdate.OvertimePay;
                employee.EmployeeStatus = vMEmployeeUpdate.EmployeeStatus;
                employee.ShiftID = vMEmployeeUpdate.ShiftID;
                employee.DepartmentID = vMEmployeeUpdate.DepartmentID;
                #endregion

                if (identityResult == null || identityResult.Succeeded)
                {
                    var updateResult = employeeService.Update(employee);
                    TempData["EmployeeResult"] = JsonConvert.SerializeObject(updateResult);

                    if (updateResult.ResultStatus == ResultStatus.Success)
                    {
                        return RedirectToAction("EmployeeDetail", new { id = vMEmployeeUpdate.EmployeeID });
                    }
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Kullanıcı hesabı mail adresi güncelleme sırasında bir hata meydana geldi mail adresiyle daha önce bir kayıt oluşturulmuş olabilir ya da hatalı giriş yaptınız.";
                    ViewBag.EmployeeResult = JsonConvert.SerializeObject(result);
                }


            }
            ViewBag.Departments = JsonConvert.DeserializeObject<List<VMDepartmentSelectList>>(TempData["Departments"].ToString());
            TempData.Keep("Departments");
            ViewBag.Shifts = JsonConvert.DeserializeObject<List<VMShiftSelectList>>(TempData["Shifts"].ToString());
            TempData.Keep("Shifts");
            ViewBag.Roles = TempData["Roles"];
            TempData.Keep("Roles");

            return View(vMEmployeeUpdate);
        }
        [Authorize(Roles ="admin")]
        [HttpPost]
        public async Task<IActionResult> EmployeeRoleSelection(VMEmployeeRoleSelectionCombine vMEmployeeRoleSelectionCombine)
        {
            var employeeEmail = (await employeeService.GetById(vMEmployeeRoleSelectionCombine.EmployeeID)).Email;
            var user = await userManager.FindByEmailAsync(employeeEmail);
            var userRoles = (await userManager.GetRolesAsync(user)).ToList();

            var selectedRoles = vMEmployeeRoleSelectionCombine.VMEmployeeRoleSelections.Where(x => x.Selected == true).ToList();

            if ((User.IsInRole("admin") && selectedRoles.Any(x => x.RoleName == "admin")) || selectedRoles.Any(x=>x.RoleName=="admin")==false)
            {

                
                foreach (var item in selectedRoles)
                {
                    if (userRoles.Contains(item.RoleName) == false)
                    {
                        await userManager.AddToRoleAsync(user, item.RoleName);
                    }
                }
                
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Admin rolünü atamak için yetkiniz bulunmamaktadır.";
                TempData["EmployeeResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("EmployeeDetail", new { id = vMEmployeeRoleSelectionCombine.EmployeeID });
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteEmployeeRole(int employeeId, string roleName)
        {
            var employeeEmail = (await employeeService.GetById(employeeId)).Email;
            var user = await userManager.FindByEmailAsync(employeeEmail);
            if (user!=null)
            {
                await userManager.RemoveFromRoleAsync(user, roleName);
            }

            return RedirectToAction("EmployeeDetail", new { id = employeeId });
        }
    }
}
