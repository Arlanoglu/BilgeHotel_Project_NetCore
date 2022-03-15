using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Reservation;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IServicePackService servicePackService;

        public ReservationController(IMapper mapper, IServicePackService servicePackService)
        {
            this.mapper = mapper;
            this.servicePackService = servicePackService;
        }
        public IActionResult WebReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WebReservation(VMWebReservation vMWebReservation)
        {

            return View();
        }
        public IActionResult SelectedRoomWebReservation()
        {
            ObjectCreator creator = new ObjectCreator();
            
            return View(creator.FactoryMethod(Utilities.Enums.ViewModels.VMWebReservation));
        }
        [HttpPost]
        public async Task<IActionResult> SelectedRoomWebReservation(VMWebReservation vMWebReservation)
        {
            var roomTypeName = JsonConvert.DeserializeObject<VMRoomTypeName>(TempData["RoomTypeName"].ToString());
            TempData.Keep("RoomTypeName");

            var servicePacks = await servicePackService.GetActive();
            var vmServicePacks = mapper.Map<List<VMServicePack>>(servicePacks);

            ViewBag.RoomTypeName = roomTypeName;
            ViewBag.ServicePacks = vmServicePacks;

            return View(vMWebReservation);
        }
        [HttpPost]
        public IActionResult WebReservationComplete(VMWebReservation vMWebReservation)
        {
            //Todo: Reservasyon kayıt işlemi yapılacak. success gelirse mail gönderilecek vs.
            return View();
        }
    }
}
