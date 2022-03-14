using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Reservation;
using WebUI.Models.RoomType;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class ReservationController : Controller
    {
        public ReservationController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SelectedRoomWebReservation()
        {
            ObjectCreator creator = new ObjectCreator();
            
            return View(creator.FactoryMethod(Utilities.Enums.ViewModels.VMWebReservation));
        }
        [HttpPost]
        public IActionResult SelectedRoomWebReservation(VMWebReservation vMWebReservation)
        {
            var roomTypeName = JsonConvert.DeserializeObject<VMRoomTypeName>(TempData["RoomTypeName"].ToString());
            TempData.Keep("RoomTypeName");

            ViewBag.RoomTypeName = roomTypeName;

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
