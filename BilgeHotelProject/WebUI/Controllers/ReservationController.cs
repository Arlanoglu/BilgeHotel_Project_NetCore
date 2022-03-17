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
        private readonly IRoomTypeService roomTypeService;

        public ReservationController(IMapper mapper, IServicePackService servicePackService, IRoomTypeService roomTypeService)
        {
            this.mapper = mapper;
            this.servicePackService = servicePackService;
            this.roomTypeService = roomTypeService;
        }
        public IActionResult WebReservation()
        {
            

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> WebReservation(VMWebReservation vMWebReservation)
        {
            var roomTypes = await roomTypeService.AvaibleRoomTypes(vMWebReservation.CheckInDate,vMWebReservation.CheckOutDate,vMWebReservation.NumberOfPeople);
            var vmRoomTypes = mapper.Map<List<VMRoomType>>(roomTypes);
            for (int i = 0; i < roomTypes.Count; i++)
            {
                vmRoomTypes[i].VMRoomPictures = mapper.Map<List<VMRoomPicture>>(roomTypes[i].RoomPictures);
            }
            ViewBag.RoomTypes = vmRoomTypes;
            return View(vMWebReservation);
        }
        public IActionResult SelectedRoomWebReservation()
        {
            ObjectCreator creator = new ObjectCreator();
            
            return View(creator.FactoryMethod(Utilities.Enums.ViewModels.VMWebReservation));
        }
        [HttpPost]
        public async Task<IActionResult> SelectedRoomWebReservation(VMWebReservation vMWebReservation)
        {
            VMRoomTypeName roomTypeName = null;
            if (vMWebReservation.RoomTypeID==0)
            {
                roomTypeName = JsonConvert.DeserializeObject<VMRoomTypeName>(TempData["RoomTypeName"].ToString());
                TempData.Keep("RoomTypeName");
            }
            else
            {
                var roomType = await roomTypeService.GetById(vMWebReservation.RoomTypeID);
                roomTypeName = mapper.Map<VMRoomTypeName>(roomType);
            }

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
