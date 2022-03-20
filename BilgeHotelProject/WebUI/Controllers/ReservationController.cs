using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
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
using Entities.Concrete;

namespace WebUI.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IServicePackService servicePackService;
        private readonly IRoomTypeService roomTypeService;
        private readonly IWebReservationService webReservationService;

        public ReservationController(IMapper mapper, IServicePackService servicePackService, IRoomTypeService roomTypeService, IWebReservationService webReservationService)
        {
            this.mapper = mapper;
            this.servicePackService = servicePackService;
            this.roomTypeService = roomTypeService;
            this.webReservationService = webReservationService;
        }
        public async Task<IActionResult> WebReservation()
        {
            var servicePacks = await servicePackService.GetActive();
            var vmServicePacks = mapper.Map<List<VMServicePack>>(servicePacks);

            ObjectCreator creator = new ObjectCreator();
            VMReservation vmReservation = (VMReservation)creator.FactoryMethod(Utilities.Enums.ViewModels.VMReservation);

            vmReservation.VMServicePacks = vmServicePacks;
            TempData["VMServicePacks"] = JsonConvert.SerializeObject(vmServicePacks);

            return View(vmReservation);
        }
        [HttpPost]
        public async Task<IActionResult> WebReservation(VMReservation vMReservation)
        {
            vMReservation.VMServicePacks = JsonConvert.DeserializeObject<List<VMServicePack>>(TempData["VMServicePacks"].ToString());
            TempData.Keep("VMServicePacks");

            var selectedServicePack = vMReservation.VMServicePacks.Where(x => x.ID == vMReservation.ServicePackID).FirstOrDefault();

            if (vMReservation.CheckInDate.Date < vMReservation.CheckOutDate.Date)
            {
                var numberOfDays = (vMReservation.CheckOutDate.Date - vMReservation.CheckInDate.Date).TotalDays;

                var roomTypes = await roomTypeService.AvaibleRoomTypes(vMReservation.CheckInDate, vMReservation.CheckOutDate, vMReservation.NumberOfPeople);
                var vmRoomTypes = mapper.Map<List<VMRoomType>>(roomTypes);

                for (int i = 0; i < roomTypes.Count; i++)
                {
                    vmRoomTypes[i].TotalPrice = (vmRoomTypes[i].Price + selectedServicePack.PackPrice) * decimal.Parse(numberOfDays.ToString());

                    vmRoomTypes[i].DiscountedPrice = webReservationService.DiscountPrice(vmRoomTypes[i].TotalPrice, vMReservation.CheckInDate, DateTime.Now, selectedServicePack.PackName);

                    vmRoomTypes[i].VMRoomPictures = mapper.Map<List<VMRoomPicture>>(roomTypes[i].RoomPictures);
                }
                vMReservation.VMRoomTypes = vmRoomTypes;

            }
            else
            {
                TempData["FormError"] = "Giriş tarihi çıkış tarihinden büyük olamaz.";
            }

            return View(vMReservation);
        }

        [HttpPost]
        public async Task<IActionResult> SelectedRoomWebReservation(VMReservation vMReservation)
        {
            var vmWebReservation = mapper.Map<VMWebReservation>(vMReservation);

            if (vMReservation.CheckInDate < vMReservation.CheckOutDate)
            {
                var roomType = await roomTypeService.GetById(vMReservation.RoomTypeID);

                ViewBag.RoomTypeName = roomType.RoomTypeName;
            }
            else
            {
                TempData["FormError"] = "Giriş tarihi çıkış tarihinden büyük olamaz.";
            }

            return View(vmWebReservation);
        }

        [HttpPost]
        public async Task<IActionResult> WebReservationComplete(VMWebReservation vMWebReservation)
        {
            if (vMWebReservation.CheckInDate < vMWebReservation.CheckOutDate)
            {
                var webReservation = mapper.Map<WebReservation>(vMWebReservation);
                var roomType = await roomTypeService.GetById(vMWebReservation.RoomTypeID);
                webReservation.ServicePack = await servicePackService.GetById(vMWebReservation.ServicePackID);
                webReservation.Price = roomType.Price + webReservation.ServicePack.PackPrice;

                webReservation.DiscountedPrice = webReservationService.DiscountPrice(webReservation.Price, webReservation.CheckInDate, webReservation.ReservationDate, webReservation.ServicePack.PackName);
            }
            else
            {
                TempData["FormError"] = "Giriş tarihi çıkış tarihinden büyük olamaz.";
            }
            //Todo: Reservasyon kayıt işlemi yapılacak. success gelirse mail gönderilecek vs.
            return View();
        }
    }
}
