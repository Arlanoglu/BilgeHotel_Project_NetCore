using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Reservation;
using Core.Utilities.Results.Concrete;
using Newtonsoft.Json;
using Entities.Enum;
using Common;
using WebUI.Models.ServicePack;
using WebUI.Utilities;
using WebUI.Utilities.Enums;
using WebUI.Models.RoomType;
using Entities.Concrete;
using WebUI.Models.StatusOfRoom;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class ReservationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IWebReservationService webReservationService;
        private readonly IReceptionReservationService receptionReservationService;
        private readonly IResult result;
        private readonly ISettingService settingService;
        private readonly IServicePackService servicePackService;
        private readonly IRoomTypeService roomTypeService;
        private readonly IRoomService roomService;

        public ReservationController(IMapper mapper, IWebReservationService webReservationService, IReceptionReservationService receptionReservationService, IResult result, ISettingService settingService, IServicePackService servicePackService, IRoomTypeService roomTypeService, IRoomService roomService)
        {
            this.mapper = mapper;
            this.webReservationService = webReservationService;
            this.receptionReservationService = receptionReservationService;
            this.result = result;
            this.settingService = settingService;
            this.servicePackService = servicePackService;
            this.roomTypeService = roomTypeService;
            this.roomService = roomService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["ReservationResult"] != null)
            {
                var reservationResult = JsonConvert.DeserializeObject<Result>(TempData["ReservationResult"].ToString());
                ViewBag.ReservationResult = reservationResult;
            }
            var webReservations = await webReservationService.GetAll();
            var receptionReservations = await receptionReservationService.GetAll();
            var vmReservations = mapper.Map<List<VMReservationList>>(webReservations);
            var vmReceptionReservations = mapper.Map<List<VMReservationList>>(receptionReservations);

            vmReservations.AddRange(vmReceptionReservations);
            return View(vmReservations);
        }
        public async Task<IActionResult> ReservationDetail(ReservationType reservationType, int id)
        {
            if (TempData["ReservationResult"] != null)
            {
                var reservationResult = JsonConvert.DeserializeObject<Result>(TempData["ReservationResult"].ToString());
                ViewBag.ReservationResult = reservationResult;
            }
            if (reservationType == ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                if (webReservation!=null)
                {
                    var vmWebReservation = mapper.Map<VMReservationDetail>(webReservation);

                    return View(vmWebReservation);
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "İlgili idye ait rezervasyon kaydı bulunmamaktadır.";
                    TempData["ReservationResult"] = JsonConvert.SerializeObject(result);

                    return RedirectToAction("Index");
                }
                
            }
            else if (reservationType == ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                if (receptionReservation!=null)
                {
                    var vmReceptionReservation = mapper.Map<VMReservationDetail>(receptionReservation);

                    return View(vmReceptionReservation);
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "İlgili idye ait rezervasyon kaydı bulunmamaktadır.";
                    TempData["ReservationResult"] = JsonConvert.SerializeObject(result);

                    return RedirectToAction("Index");
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili rezervasyon kaydı bulunmamaktadır.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> ChangePayment(ReservationType reservationType, int id)
        {
            if (reservationType==ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                if (webReservation.Payment)
                    webReservation.Payment = false;
                else
                    webReservation.Payment = true;
                var updateResult = webReservationService.Update(webReservation);

                TempData["ReservationResult"] = JsonConvert.SerializeObject(updateResult);                
            }
            else if (reservationType == ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                if (receptionReservation.Payment)
                    receptionReservation.Payment = false;
                else
                    receptionReservation.Payment = true;
                var updateResult = receptionReservationService.Update(receptionReservation);

                TempData["ReservationResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili rezervasyon kaydı bulunmamaktadır.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("ReservationDetail", new { reservationType = reservationType, id = id });
        }
        public async Task<IActionResult> CancelReservation(ReservationType reservationType, int id)
        {
            if (reservationType == ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                var setting = (await settingService.GetActive()).FirstOrDefault();
                var cancelResult = webReservationService.CancelReservation(webReservation);

                //Rezervasyon iptal mail gönderimi.
                if (cancelResult.ResultStatus == ResultStatus.Success)
                {
                    var message = MailSender.CancelReservationMessage(webReservation.ID, webReservation.CheckInDate, webReservation.CheckOutDate);
                    //Kullanıcıya gönderilen mail.
                    MailSender.SendMail(webReservation.AppUser.Email, "Rezervasyon İptal", message, setting);
                    if (webReservation.AppUser.Email != webReservation.Email)
                    {
                        //Rezervasyon yapan kişinin bilgilerine gönderilen mail.
                        MailSender.SendMail(webReservation.Email, "Rezervasyon İptal", message, setting);
                    }
                }
                TempData["ReservationResult"] = JsonConvert.SerializeObject(cancelResult);
            }
            else if (reservationType == ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                var setting = (await settingService.GetActive()).FirstOrDefault();
                var cancelResult = receptionReservationService.CancelReservation(receptionReservation);

                //Rezervasyon iptal mail gönderimi.
                if (cancelResult.ResultStatus == ResultStatus.Success && receptionReservation.Email!=null)
                {
                    var message = MailSender.CancelReservationMessage(receptionReservation.ID, receptionReservation.CheckInDate, receptionReservation.CheckOutDate);
                    //Rezervasyon yapan kişinin bilgilerine gönderilen mail.
                    MailSender.SendMail(receptionReservation.Email, "Rezervasyon İptal", message, setting);
                }

                TempData["ReservationResult"] = JsonConvert.SerializeObject(cancelResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili rezervasyon kaydı bulunmamaktadır.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("ReservationDetail", new { reservationType = reservationType, id = id });

        }
        public async Task<IActionResult> ReceptionReservation()
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
        public async Task<IActionResult> ReceptionReservation(VMReservation vMReservation)
        {
            vMReservation.VMServicePacks = JsonConvert.DeserializeObject<List<VMServicePack>>(TempData["VMServicePacks"].ToString());
            TempData.Keep("VMServicePacks");

            var selectedServicePack = vMReservation.VMServicePacks.Where(x => x.ID == vMReservation.ServicePackID).FirstOrDefault();

            if ((vMReservation.CheckInDate.Date < vMReservation.CheckOutDate.Date) && (vMReservation.CheckInDate.Date >= DateTime.Now.Date))
            {
                var numberOfDays = (vMReservation.CheckOutDate.Date - vMReservation.CheckInDate.Date).TotalDays;

                var roomTypes = await roomTypeService.AvaibleRoomTypes(vMReservation.CheckInDate, vMReservation.CheckOutDate, vMReservation.NumberOfPeople);
                                
                
                if (roomTypes.Count > 0)
                {
                    var vmRoomTypes = mapper.Map<List<VMRoomType>>(roomTypes);

                    for (int i = 0; i < roomTypes.Count; i++)
                    {
                        vmRoomTypes[i].TotalPrice = (vmRoomTypes[i].Price + selectedServicePack.PackPrice) * decimal.Parse(numberOfDays.ToString());

                        vmRoomTypes[i].VMRoomPictures = mapper.Map<List<VMRoomPicture>>(roomTypes[i].RoomPictures);
                    }
                    vMReservation.VMRoomTypes = vmRoomTypes;
                }
                else
                {
                    TempData["ReservationResult"] = "Girmiş olduğunuz kriterlere uygun müsait oda bulunamadı.";
                }
            }
            else
            {
                TempData["ReservationResult"] = "Tarih bilgilerinde hata gözlemlendi. Lütfen giriş ve çıkış tarihlerini kontrol ediniz.";
            }
            return View(vMReservation);
        }
        [HttpPost]
        public async Task<IActionResult> SelectedRoomReservation(VMReservation vMReservation)
        {
            var vmReservationCreate = mapper.Map<VMReceptionReservationCreate>(vMReservation);

            var roomType = await roomTypeService.GetById(vMReservation.RoomTypeID);
            var vmRoomType = mapper.Map<VMRoomType>(roomType);
            var servicePacks = JsonConvert.DeserializeObject<List<VMServicePack>>(TempData["VMServicePacks"].ToString());
            TempData.Keep("VMServicePacks");
            var selectedServicePack = servicePacks.Where(x => x.ID == vmReservationCreate.ServicePackID).FirstOrDefault();

            ViewBag.RoomType = vmRoomType;
            ViewBag.ServicePack = mapper.Map<VMServicePack>(selectedServicePack);

            return View(vmReservationCreate);
        }
        [HttpPost]
        public async Task<IActionResult> ReservationComplete(VMReceptionReservationCreate vMReservationCreate)
        {
            var avaibleRooms = await roomService.AvaibleRooms(vMReservationCreate.CheckInDate, vMReservationCreate.CheckOutDate, vMReservationCreate.NumberOfPeople);

            if (avaibleRooms.Count > 0)
            {
                var filterRooms = avaibleRooms.Where(x => x.RoomTypeID == vMReservationCreate.RoomTypeID).ToList();

                if (filterRooms.Count > 0)
                {
                    vMReservationCreate.RoomID = filterRooms.Select(x => x.ID).FirstOrDefault();

                    var receptionReservation = mapper.Map<ReceptionReservation>(vMReservationCreate);

                    ObjectCreator creator = new ObjectCreator();
                    var vmStatusOfRoom = (VMStatusOfRoom)creator.FactoryMethod(ViewModels.VMStatusOfRoom);
                    vmStatusOfRoom.StatusStartDate = receptionReservation.CheckInDate;
                    vmStatusOfRoom.StatusEndDate = receptionReservation.CheckOutDate;
                    vmStatusOfRoom.RoomStatus = RoomStatus.Rezerve;
                    vmStatusOfRoom.RoomID = receptionReservation.RoomID;
                    var statusOfRoom = mapper.Map<StatusOfRoom>(vmStatusOfRoom);

                    var createResult = (Result)receptionReservationService.ReservationCreate(receptionReservation, statusOfRoom);

                    //Rezervasyon sonunda mail gönderim işlemi
                    if (createResult.ResultStatus == ResultStatus.Success && receptionReservation.Email!=null)
                    {
                        var setting = (await settingService.GetActive()).FirstOrDefault();
                        //Id veritabanına kayıt edildikten sonra oluştuğu için bazı kriterler ile rezervasyon id ve tarihi bulma işlemi.
                        var reservationID = (await receptionReservationService.GetDefault(x => x.CheckInDate == receptionReservation.CheckInDate && x.CheckOutDate== receptionReservation.CheckOutDate && x.RoomID== receptionReservation.RoomID && x.ServicePackID== receptionReservation.ServicePackID)).OrderByDescending(x => x.ID).FirstOrDefault().ID;

                        var reservationDate = (await webReservationService.GetDefault(x => x.CheckInDate == receptionReservation.CheckInDate && x.CheckOutDate == receptionReservation.CheckOutDate && x.RoomID == receptionReservation.RoomID && x.ServicePackID == receptionReservation.ServicePackID)).OrderByDescending(x => x.ID).FirstOrDefault().ReservationDate;

                        var message = MailSender.ReservationCompleteMessage(reservationID, reservationDate, receptionReservation.CheckInDate, receptionReservation.CheckOutDate);

                        //Rezervasyon yapan kişinin bilgilerine gönderilen mail.
                        MailSender.SendMail(receptionReservation.Email, "Rezervasyon", message, setting);

                        
                    }
                    TempData["ReservationResult"] = createResult.Message;
                }
                else
                {
                    TempData["ReservationResult"] = "Girilen kriterlere uygun rezervasyon bulunmamaktadır. Lütfen rezervasyon ekranından tekrar sorgulama yapınız.";
                }
            }
            else
            {
                TempData["ReservationResult"] = "Girilen kriterlere uygun rezervasyon bulunmamaktadır. Lütfen rezervasyon ekranından tekrar sorgulama yapınız.";
            }

            return RedirectToAction("ReceptionReservation");
        }
    }
}
