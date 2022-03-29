using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ExtraService;
using WebUI.Models.Registration;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class RegistrationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRegistrationService registrationService;
        private readonly IUseOfExtraServiceService useOfExtraServiceService;

        public RegistrationController(IMapper mapper, IRegistrationService registrationService, IUseOfExtraServiceService useOfExtraServiceService)
        {
            this.mapper = mapper;
            this.registrationService = registrationService;
            this.useOfExtraServiceService = useOfExtraServiceService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RegistrationResult"] != null)
            {
                var registrationResult = JsonConvert.DeserializeObject<Result>(TempData["RegistrationResult"].ToString());
                ViewBag.RegistrationResult = registrationResult;
            }
            var registrations = await registrationService.GetAll();
            var vmRegistrations = mapper.Map<List<VMRegistrationList>>(registrations);

            return View(vmRegistrations);
        }
        public async Task<IActionResult> RegistrationDetail(int id)
        {
            if (TempData["RegistrationResult"] != null)
            {
                var registrationResult = JsonConvert.DeserializeObject<Result>(TempData["RegistrationResult"].ToString());
                ViewBag.RegistrationResult = registrationResult;
            }
            var registrations = await registrationService.GetById(id);
            var vmRegistrationDetails = mapper.Map<VMRegistrationDetail>(registrations);

            int i = 0;
            foreach (var item in registrations.UseOfExtraServices)
            {
                vmRegistrationDetails.VMExtraServices[i].Quantity = item.Quantity;
                i++;
            }

            return View(vmRegistrationDetails);
        }
        [HttpPost]
        public IActionResult AddUseOfExtraService(VMUseOfExtraServiceCreate vMUseOfExtraServiceCreate)
        {
            var useOfExtraService = mapper.Map<UseOfExtraService>(vMUseOfExtraServiceCreate);

            var createResult = useOfExtraServiceService.Create(useOfExtraService);
            TempData["RegistrationResult"] = JsonConvert.SerializeObject(createResult);

            return RedirectToAction("RegistrationDetail", new { id= vMUseOfExtraServiceCreate.RegistrationID});
        }
    }
}
