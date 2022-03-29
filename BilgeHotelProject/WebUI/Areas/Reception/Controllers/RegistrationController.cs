using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Registration;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class RegistrationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRegistrationService registrationService;

        public RegistrationController(IMapper mapper, IRegistrationService registrationService)
        {
            this.mapper = mapper;
            this.registrationService = registrationService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RegistrationResult"] != null)
            {
                var reservationResult = JsonConvert.DeserializeObject<Result>(TempData["ReservationResult"].ToString());
                ViewBag.RegistrationResult = reservationResult;
            }
            var registrations = await registrationService.GetAll();
            var vmRegistrations = mapper.Map<List<VMRegistrationList>>(registrations);

            return View(vmRegistrations);
        }
        public async Task<IActionResult> RegistrationDetail(int id)
        {
            var registrations = await registrationService.GetById(id);
            var vmRegistrationDetails = mapper.Map<VMRegistrationDetail>(registrations);

            return View(vmRegistrationDetails);
        }
    }
}
