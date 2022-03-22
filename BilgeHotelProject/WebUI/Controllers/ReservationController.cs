﻿using AutoMapper;
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
using WebUI.Models.StatusOfRoom;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using WebUI.Utilities.Enums;
using Microsoft.AspNetCore.Identity;
using Common;

namespace WebUI.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IServicePackService servicePackService;
        private readonly IRoomTypeService roomTypeService;
        private readonly IWebReservationService webReservationService;
        private readonly IRoomService roomService;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ISettingService settingService;

        public ReservationController(IMapper mapper, IServicePackService servicePackService, IRoomTypeService roomTypeService, IWebReservationService webReservationService, IRoomService roomService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ISettingService settingService)
        {
            this.mapper = mapper;
            this.servicePackService = servicePackService;
            this.roomTypeService = roomTypeService;
            this.webReservationService = webReservationService;
            this.roomService = roomService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.settingService = settingService;
        }
        public async Task<IActionResult> WebReservation()
        {
            var servicePacks = await servicePackService.GetActive();
            var vmServicePacks = mapper.Map<List<VMServicePack>>(servicePacks);

            ObjectCreator creator = new ObjectCreator();
            VMReservation vmReservation = (VMReservation)creator.FactoryMethod(ViewModels.VMReservation);

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

            if ((vMReservation.CheckInDate.Date < vMReservation.CheckOutDate.Date) && (vMReservation.CheckInDate.Date >= DateTime.Now.Date))
            {
                var numberOfDays = (vMReservation.CheckOutDate.Date - vMReservation.CheckInDate.Date).TotalDays;

                var roomTypes = await roomTypeService.AvaibleRoomTypes(vMReservation.CheckInDate, vMReservation.CheckOutDate, vMReservation.NumberOfPeople);

                

                if (vMReservation.RoomTypeID!=0)
                {
                    var roomResult = roomTypes.Any(x => x.ID == vMReservation.RoomTypeID);
                    if (roomResult)
                    {
                        var roomType = await roomTypeService.GetById(vMReservation.RoomTypeID);
                        var vmRoomType = mapper.Map<VMRoomType>(roomType);
                        vmRoomType.TotalPrice = (vmRoomType.Price + selectedServicePack.PackPrice) * decimal.Parse(numberOfDays.ToString());
                        vmRoomType.DiscountedPrice = webReservationService.DiscountPrice(vmRoomType.TotalPrice, vMReservation.CheckInDate, DateTime.Now, selectedServicePack.PackName);
                        vmRoomType.VMRoomPictures = mapper.Map<List<VMRoomPicture>>(roomType.RoomPictures);

                        List<VMRoomType> vmRoomTypes = new List<VMRoomType>();
                        vmRoomTypes.Add(vmRoomType);

                        vMReservation.VMRoomTypes = vmRoomTypes;
                    }
                    else
                    {
                        TempData["FormError"] = "Girmiş olduğunuz kriterlere uygun müsait oda bulunamadı.";
                        return RedirectToAction("RoomDetail", "Room", new { id = vMReservation.RoomTypeID });
                    }
                }
                else if (roomTypes.Count > 0)
                {
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
                    TempData["FormError"] = "Girmiş olduğunuz kriterlere uygun müsait oda bulunamadı.";
                }
                

            }
            else
            {
                TempData["FormError"] = "Tarih bilgilerinde hata gözlemlendi. Lütfen giriş ve çıkış tarihlerini kontrol ediniz.";                
            }

            if (vMReservation.RoomTypeID != 0)
            {
                return RedirectToAction("RoomDetail", "Room", new { id = vMReservation.RoomTypeID });
            }
            else
            {
                return View(vMReservation);
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> SelectedRoomWebReservation(VMReservation vMReservation)
        {
            var vmWebReservation = mapper.Map<VMWebReservation>(vMReservation);

            var roomType = await roomTypeService.GetById(vMReservation.RoomTypeID);
            var vmRoomType = mapper.Map<VMRoomType>(roomType);
            var servicePacks = JsonConvert.DeserializeObject<List<VMServicePack>>(TempData["VMServicePacks"].ToString());
            TempData.Keep("VMServicePacks");
            var selectedServicePack = servicePacks.Where(x => x.ID == vmWebReservation.ServicePackID).FirstOrDefault();

            ViewBag.RoomType = vmRoomType;
            ViewBag.ServicePack = mapper.Map<VMServicePack>(selectedServicePack);

            return View(vmWebReservation);
        }

        [HttpPost]
        public async Task<IActionResult> WebReservationComplete(VMWebReservation vMWebReservation)
        {
            var avaibleRooms = await roomService.AvaibleRooms(vMWebReservation.CheckInDate, vMWebReservation.CheckOutDate, vMWebReservation.NumberOfPeople);

            if (avaibleRooms.Count>0)
            {
                var filterRooms = avaibleRooms.Where(x => x.RoomTypeID == vMWebReservation.RoomTypeID).ToList();

                if (filterRooms.Count > 0)
                {
                    vMWebReservation.RoomID = filterRooms.Select(x => x.ID).FirstOrDefault();

                    var webReservation = mapper.Map<WebReservation>(vMWebReservation);

                    ObjectCreator creator = new ObjectCreator();
                    var vmStatusOfRoom = (VMStatusOfRoom)creator.FactoryMethod(ViewModels.VMStatusOfRoom);
                    vmStatusOfRoom.StatusStartDate = vMWebReservation.CheckInDate;
                    vmStatusOfRoom.StatusEndDate = vMWebReservation.CheckOutDate;
                    vmStatusOfRoom.RoomStatus = Entities.Enum.RoomStatus.Rezerve;
                    vmStatusOfRoom.RoomID = vMWebReservation.RoomID;
                    var statusOfRoom = mapper.Map<StatusOfRoom>(vmStatusOfRoom);

                    var createResult = (Result)webReservationService.ReservationCreate(webReservation, statusOfRoom);

                    //Rezervasyon sonunda mail gönderim işlemi
                    if (createResult.ResultStatus==ResultStatus.Success && signInManager.IsSignedIn(User))
                    {
                        var user = await userManager.GetUserAsync(User);
                        var setting = (await settingService.GetActive()).FirstOrDefault();
                        var reservationID = (await webReservationService.GetDefault(x => x.AppUserID == user.Id)).FirstOrDefault().ID;
                        var reservationDate = (await webReservationService.GetDefault(x => x.AppUserID == user.Id)).FirstOrDefault().ReservationDate;
                        var message = MailSender.ReservationCompleteMessage(reservationID, reservationDate, vMWebReservation.CheckInDate, vMWebReservation.CheckOutDate);

                        //Kullanıcıya gönderilen mail.
                        MailSender.SendMail(user.Email, "Rezervasyon", message, setting);
                        if (user.Email!=vMWebReservation.Email)
                        {
                            //Rezervasyona gönderilen mail.
                            var a = MailSender.SendMail(vMWebReservation.Email, "Rezervasyon", message, setting);
                        }                       
                        
                    }

                    TempData["ReservationResult"] = JsonConvert.SerializeObject(createResult);
                }
                else
                {
                    TempData["FormError"] = "Girilen kriterlere uygun rezervasyon bulunmamaktadır. Lütfen rezervasyon ekranından tekrar sorgulama yapınız.";
                }
            }
            else
            {
                TempData["FormError"] = "Girilen kriterlere uygun rezervasyon bulunmamaktadır. Lütfen rezervasyon ekranından tekrar sorgulama yapınız.";
            }

            
            //Todo: Reservasyon kayıt işlemi yapılacak. success gelirse mail gönderilecek vs.
            return RedirectToAction("WebReservationResult",vMWebReservation);
        }

        public IActionResult WebReservationResult(VMWebReservation vMWebReservation)
        {
            var result = JsonConvert.DeserializeObject<Result>(TempData["ReservationResult"].ToString());
            
            ViewBag.ReservationResult = result;

            return View(vMWebReservation);
        }

        public async Task<IActionResult> CancelWebReservation(int id)
        {
            var webReservation = await webReservationService.GetById(id);
            var cancelResult = webReservationService.CancelReservation(webReservation);

            var user = await userManager.GetUserAsync(User);

            if (user != null)
            {
                TempData["CancelReservationResult"] = cancelResult.Message;
                return RedirectToAction("MyReservations", "Account", new { id = user.Id });
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
