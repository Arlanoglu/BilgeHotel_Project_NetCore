using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Guest;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class GuestController : Controller
    {
        private readonly IMapper mapper;
        private readonly IGuestService guestService;
        private readonly IRegistrationService registrationService;

        public GuestController(IMapper mapper, IGuestService guestService, IRegistrationService registrationService)
        {
            this.mapper = mapper;
            this.guestService = guestService;
            this.registrationService = registrationService;
        }

        //Müşterileri listeler. Ancak kayıt tarafından bir müşteri eklemek için listeleme talebi gelirse yani id dolu gelirse ilgili kayıta müşteriyi eklemek için registrationId ile listeleme yapar.
        public async Task<IActionResult> Index(int id)
        {
            var guests = await guestService.GetActive();

            ObjectCreator creator = new ObjectCreator();
            var vmguestList = (VMGuestRegistrationSelection)creator.FactoryMethod(ViewModels.VMGuestRegistrationSelection);
            vmguestList.VMGuestLists = mapper.Map<List<VMGuestList>>(guests);
            if (await registrationService.Any(x=>x.ID==id))
            {
                vmguestList.RegistrationID = id;
            }
            return View(vmguestList);
        }
    }
}
