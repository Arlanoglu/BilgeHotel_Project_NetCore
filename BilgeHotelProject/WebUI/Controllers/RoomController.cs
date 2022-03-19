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
    public class RoomController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomTypeService roomTypeService;

        public RoomController(IMapper mapper, IRoomTypeService roomTypeService)
        {
            this.mapper = mapper;
            this.roomTypeService = roomTypeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> RoomDetail(int id)
        {
            var roomType = await roomTypeService.GetById(id);            
            var vmRoomType = mapper.Map<VMRoomTypeName>(roomType);

            TempData["RoomTypeName"] = JsonConvert.SerializeObject(vmRoomType);

            ViewBag.RoomTypeName = vmRoomType;

            //ObjectCreator creator = new ObjectCreator();
            //var vmWebReservation = (VMWebReservation)creator.FactoryMethod(Utilities.Enums.ViewModels.VMWebReservation);
            //vmWebReservation.RoomTypeID = id;
            return View();
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
