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
using WebUI.Utilities.Enums;

namespace WebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomTypeService roomTypeService;
        private readonly IServicePackService servicePackService;

        public RoomController(IMapper mapper, IRoomTypeService roomTypeService, IServicePackService servicePackService)
        {
            this.mapper = mapper;
            this.roomTypeService = roomTypeService;
            this.servicePackService = servicePackService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> RoomDetail(int id)
        {
            var roomType = await roomTypeService.GetById(id);
            var vmRoomType = mapper.Map<VMRoomType>(roomType);

            List<VMRoomType> vMRoomTypes = new List<VMRoomType>();
            vMRoomTypes.Add(vmRoomType);

            var servicePacks = await servicePackService.GetActive();
            var vmServicePacks = mapper.Map<List<VMServicePack>>(servicePacks);

            ObjectCreator creator = new ObjectCreator();            

            var vmReservation = (VMReservation)creator.FactoryMethod(ViewModels.VMReservation);
            vmReservation.RoomTypeID = id;
            vmReservation.VMServicePacks = vmServicePacks;
            vmReservation.VMRoomTypes = vMRoomTypes;


            ViewBag.RoomTypeName = roomType.RoomTypeName;

            return View(vmReservation);
        }

        [HttpPost]
        public IActionResult RoomDetailReservation(VMWebReservation vMWebReservation)
        {
            if (vMWebReservation.CheckInDate < vMWebReservation.CheckOutDate)
            {
                return RedirectToAction("SelectedRoomWebReservation", "Reservation",vMWebReservation);
            }
            else
            {
                TempData["FormError"] = "Giriş tarihi çıkış tarihinden büyük olamaz.";
            }
            
            return RedirectToAction("RoomDetail", new { id = vMWebReservation.RoomTypeID });
        }
    }
}
