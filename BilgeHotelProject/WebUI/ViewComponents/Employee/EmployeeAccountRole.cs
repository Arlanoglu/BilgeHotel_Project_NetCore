using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Employee;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.ViewComponents.Employee
{
    public class EmployeeAccountRole : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly RoleManager<IdentityRole> roleManager;

        public EmployeeAccountRole(IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            this.mapper = mapper;
            this.roleManager = roleManager;
        }
        public IViewComponentResult Invoke(int id)
        {
            ObjectCreator creator = new ObjectCreator();
            var vmEmployeeRoleSelectionCombine = (VMEmployeeRoleSelectionCombine)creator.FactoryMethod(ViewModels.VMEmployeeRoleSelectionCombine);          
            
            var roles = roleManager.Roles.ToList();
            vmEmployeeRoleSelectionCombine.EmployeeID = id;
            vmEmployeeRoleSelectionCombine.VMEmployeeRoleSelections = mapper.Map<List<VMEmployeeRoleSelection>>(roles);

            return View(vmEmployeeRoleSelectionCombine);
        }
    }
}
