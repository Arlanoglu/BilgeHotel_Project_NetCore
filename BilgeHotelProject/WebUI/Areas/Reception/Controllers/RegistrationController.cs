using AutoMapper;
using Business.Services.Abstract;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.Enum;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ExtraService;
using WebUI.Models.Registration;
using WebUI.Models.Reservation;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;
using WebUI.Models.StatusOfRoom;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class RegistrationController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRegistrationService registrationService;
        private readonly IUseOfExtraServiceService useOfExtraServiceService;
        private readonly IResult result;
        private readonly IServicePackService servicePackService;
        private readonly IRoomTypeService roomTypeService;
        private readonly IRoomService roomService;
        private readonly IWebReservationService webReservationService;
        private readonly IReceptionReservationService receptionReservationService;
        private readonly IStatusOfRoomService statusOfRoomService;
        private readonly IIncomeService incomeService;
        private readonly IGuestRegistrationService guestRegistrationService;
        private readonly IGuestService guestService;

        public RegistrationController(IMapper mapper, IRegistrationService registrationService, IUseOfExtraServiceService useOfExtraServiceService, IResult result, IServicePackService servicePackService, IRoomTypeService roomTypeService, IRoomService roomService, IWebReservationService webReservationService, IReceptionReservationService receptionReservationService, IStatusOfRoomService statusOfRoomService, IIncomeService incomeService, IGuestRegistrationService guestRegistrationService, IGuestService guestService)
        {
            this.mapper = mapper;
            this.registrationService = registrationService;
            this.useOfExtraServiceService = useOfExtraServiceService;
            this.result = result;
            this.servicePackService = servicePackService;
            this.roomTypeService = roomTypeService;
            this.roomService = roomService;
            this.webReservationService = webReservationService;
            this.receptionReservationService = receptionReservationService;
            this.statusOfRoomService = statusOfRoomService;
            this.incomeService = incomeService;
            this.guestRegistrationService = guestRegistrationService;
            this.guestService = guestService;
        }
        //Misafir detay bölümünden kayıt görmek
        public async Task<IActionResult> Index(int id)
        {
            if (TempData["RegistrationResult"] != null)
            {
                var registrationResult = JsonConvert.DeserializeObject<Result>(TempData["RegistrationResult"].ToString());
                ViewBag.RegistrationResult = registrationResult;
            }
            var registrations = await registrationService.GetAll();
            if (id!=0)
            {
                if (registrations.Any(x => x.GuestRegistrations.Any(x => x.GuestID == id)))
                {
                    var filterRegistrations = registrations.Where(x => x.GuestRegistrations.Any(x => x.GuestID == id)).ToList();
                    var filterVmRegistrations = mapper.Map<List<VMRegistrationList>>(filterRegistrations);

                    result.ResultStatus = ResultStatus.Success;
                    result.Message = $"{id} nolu idye ait misafir kayıtları.";
                    ViewBag.RegistrationResult = result;
                    return View(filterVmRegistrations);
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Misafire ait kayıt bulunamadı.";
                    TempData["GuestResult"] = JsonConvert.SerializeObject(result);
                    return RedirectToAction("GuestDetail", "Guest", new { id = id });
                }
            }
            var vmRegistrations = mapper.Map<List<VMRegistrationList>>(registrations);

            return View(vmRegistrations);
        }
        public async Task<IActionResult> RegistrationDetail(int id)
        {
            if (TempData["RegistrationResult"] != null)
            {
                var registrationResult = JsonConvert.DeserializeObject<Result>(TempData["RegistrationResult"].ToString());
                ViewBag.RegistrationResult = registrationResult;
            }
            var registrations = await registrationService.GetById(id);
            var vmRegistrationDetails = mapper.Map<VMRegistrationDetail>(registrations);

            int i = 0;
            foreach (var item in registrations.UseOfExtraServices)
            {
                vmRegistrationDetails.VMExtraServices[i].Quantity = item.Quantity;
                i++;
            }

            return View(vmRegistrationDetails);
        }
        [HttpPost]
        public IActionResult AddUseOfExtraService(VMUseOfExtraServiceCreate vMUseOfExtraServiceCreate)
        {
            if (vMUseOfExtraServiceCreate.Quantity!=0)
            {
                var useOfExtraService = mapper.Map<UseOfExtraService>(vMUseOfExtraServiceCreate);

                var createResult = useOfExtraServiceService.Create(useOfExtraService);
                TempData["RegistrationResult"] = JsonConvert.SerializeObject(createResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Adet en az 1 girilmelidir.";
            }

            return RedirectToAction("RegistrationDetail", new { id= vMUseOfExtraServiceCreate.RegistrationID});
        }
        public async Task<IActionResult> DeleteUseOfExtraService(int extraServiceId, int registrationId)
        {
            var useOfExtraService = (await useOfExtraServiceService.GetDefault(x => x.ExtraServiceID == extraServiceId && x.RegistrationID == registrationId)).FirstOrDefault();

            var deleteResult = useOfExtraServiceService.RemoveForce(useOfExtraService);
            TempData["RegistrationResult"] = JsonConvert.SerializeObject(deleteResult);

            return RedirectToAction("RegistrationDetail", new { id = registrationId });
        }
        public async Task<IActionResult> RoomQuery()
        {
            var servicePacks = await servicePackService.GetActive();
            var vmServicePacks = mapper.Map<List<VMServicePack>>(servicePacks);

            ObjectCreator creator = new ObjectCreator();
            var vMRegistrationCreate = (VMRegistrationCreate)creator.FactoryMethod(ViewModels.VMRegistrationCreate);

            vMRegistrationCreate.VMServicePacks = vmServicePacks;
            TempData["VMServicePacks"] = JsonConvert.SerializeObject(vmServicePacks);

            return View(vMRegistrationCreate);
        }
        [HttpPost]
        public async Task<IActionResult> RoomQuery(VMRegistrationCreate vMRegistrationCreate)
        {
            vMRegistrationCreate.VMServicePacks = JsonConvert.DeserializeObject<List<VMServicePack>>(TempData["VMServicePacks"].ToString());
            TempData.Keep("VMServicePacks");

            var selectedServicePack = vMRegistrationCreate.VMServicePacks.Where(x => x.ID == vMRegistrationCreate.ServicePackID).FirstOrDefault();

            if ((vMRegistrationCreate.CheckInDate.Date < vMRegistrationCreate.CheckOutDate.Date) && (vMRegistrationCreate.CheckInDate.Date >= DateTime.Now.Date))
            {
                var numberOfDays = (vMRegistrationCreate.CheckOutDate.Date - vMRegistrationCreate.CheckInDate.Date).TotalDays;

                var roomTypes = await roomTypeService.AvaibleRoomTypes(vMRegistrationCreate.CheckInDate, vMRegistrationCreate.CheckOutDate, vMRegistrationCreate.NumberOfPeople);


                if (roomTypes.Count > 0)
                {
                    var vmRoomTypes = mapper.Map<List<VMRoomType>>(roomTypes);

                    for (int i = 0; i < roomTypes.Count; i++)
                    {
                        vmRoomTypes[i].TotalPrice = (vmRoomTypes[i].Price + selectedServicePack.PackPrice) * decimal.Parse(numberOfDays.ToString());

                        vmRoomTypes[i].VMRoomPictures = mapper.Map<List<VMRoomPicture>>(roomTypes[i].RoomPictures);
                    }
                    vMRegistrationCreate.VMRoomTypes = vmRoomTypes;
                }
                else
                {
                    TempData["RegistrationCreateResult"] = "Girmiş olduğunuz kriterlere uygun müsait oda bulunamadı.";
                }
            }
            else
            {
                TempData["RegistrationCreateResult"] = "Tarih bilgilerinde hata gözlemlendi. Lütfen giriş ve çıkış tarihlerini kontrol ediniz.";
            }
            return View(vMRegistrationCreate);
        }
        [HttpPost]
        public async Task<IActionResult> SelectedRoomRegistration(VMRegistrationCreate vMRegistrationCreate)
        {
            var roomType = await roomTypeService.GetById(vMRegistrationCreate.RoomTypeID);
            var vmRoomType = mapper.Map<VMRoomType>(roomType);
            var servicePacks = JsonConvert.DeserializeObject<List<VMServicePack>>(TempData["VMServicePacks"].ToString());
            TempData.Keep("VMServicePacks");
            var selectedServicePack = servicePacks.Where(x => x.ID == vMRegistrationCreate.ServicePackID).FirstOrDefault();

            ViewBag.RoomType = vmRoomType;
            ViewBag.ServicePack = mapper.Map<VMServicePack>(selectedServicePack);

            return View(vMRegistrationCreate);
        }
        [HttpPost]
        public async Task<IActionResult> RegistrationCreate(VMRegistrationCreate vMRegistrationCreate)
        {
            if (ModelState.IsValid)
            {
                var avaibleRooms = await roomService.AvaibleRooms(vMRegistrationCreate.CheckInDate, vMRegistrationCreate.CheckOutDate, vMRegistrationCreate.NumberOfPeople);

                if (avaibleRooms.Count > 0)
                {
                    var filterRooms = avaibleRooms.Where(x => x.RoomTypeID == vMRegistrationCreate.RoomTypeID).ToList();

                    if (filterRooms.Count > 0)
                    {
                        vMRegistrationCreate.RoomID = filterRooms.Select(x => x.ID).FirstOrDefault();
                        if (vMRegistrationCreate.ReservationID==0)
                        {
                            vMRegistrationCreate.RegistrationType = RegistrationType.ResepsiyonKayit;
                        }
                        var registration = mapper.Map<Registration>(vMRegistrationCreate);

                        ObjectCreator creator = new ObjectCreator();
                        var vmStatusOfRoom = (VMStatusOfRoom)creator.FactoryMethod(ViewModels.VMStatusOfRoom);
                        vmStatusOfRoom.StatusStartDate = registration.CheckInDate;
                        vmStatusOfRoom.StatusEndDate = registration.CheckOutDate;
                        vmStatusOfRoom.RoomStatus = RoomStatus.Dolu;
                        vmStatusOfRoom.RoomID = registration.RoomID;
                        var statusOfRoom = mapper.Map<StatusOfRoom>(vmStatusOfRoom);

                        var createResult = (Result)registrationService.CreateRegistrationWithoutReservation(registration, statusOfRoom);

                        
                        TempData["RegistrationCreateResult"] = createResult.Message;

                        if (createResult.ResultStatus==ResultStatus.Success)
                        {
                            //Odanın durumunun doluya çekilmesi.
                            var room = await roomService.GetById(registration.RoomID);
                            room.RoomStatus = RoomStatus.Dolu;
                            roomService.Update(room);

                            //Kaydedilen kayıtın idsini yakalama
                            var registrationId = (await registrationService.GetDefault(x =>
                            x.CheckInDate == registration.CheckInDate.Date &&
                            x.CheckOutDate == registration.CheckOutDate.Date &&
                            x.RoomID == registration.RoomID &&
                            x.ServicePackID == registration.ServicePackID &&
                            x.RegistrationStatus == RegistrationStatus.GirisYapildi &&
                            x.Status == Status.Active)).OrderByDescending(x => x.ID).FirstOrDefault().ID;

                            TempData["RegistrationCreateResult"] = JsonConvert.SerializeObject(createResult);
                            return RedirectToAction("RegistrationDetail", new { id=registrationId });
                        }
                    }
                    else
                    {
                        TempData["RegistrationCreateResult"] = "Girilen kriterlere uygun rezervasyon bulunmamaktadır. Lütfen rezervasyon ekranından tekrar sorgulama yapınız.";
                    }
                }
                else
                {
                    TempData["RegistrationCreateResult"] = "Girilen kriterlere uygun rezervasyon bulunmamaktadır. Lütfen rezervasyon ekranından tekrar sorgulama yapınız.";
                }

            }
            else
            {
                TempData["RegistrationCreateResult"] = "Rezervasyon oluşturulamadı lütfen zorunlu alanları doldurun.";
                
            }
            return RedirectToAction("RoomQuery");
        }
        public async Task<IActionResult> RegistrationToReservation(ReservationType reservationType, int id)
        {
            bool boolResult;
            IResult createResult = null;
            Registration registration = null;

            if (reservationType==ReservationType.Reception)
            {
                var receptionReservation = await receptionReservationService.GetById(id);
                boolResult = await registrationService.Any(x => x.CheckInDate == receptionReservation.CheckInDate.Date && x.CheckOutDate == receptionReservation.CheckOutDate.Date && x.RoomID == receptionReservation.RoomID && x.RegistrationType==RegistrationType.ResepsiyonRezervasyon && x.ReservationID==id);
                if (boolResult==false)
                {
                    registration = mapper.Map<Registration>(receptionReservation);
                    registration.RegistrationType = RegistrationType.ResepsiyonRezervasyon;
                    registration.ID = 0;
                    registration.ReservationID = id;
                    createResult = registrationService.Create(registration);
                    if (createResult.ResultStatus == ResultStatus.Success)
                    {
                        receptionReservation.ReservationStatus = ReservationStatus.GirisYapildi;
                        receptionReservationService.Update(receptionReservation);
                    }
                }
            }
            else if(reservationType == ReservationType.Web)
            {
                var webReservation = await webReservationService.GetById(id);
                boolResult = await registrationService.Any(x => x.CheckInDate == webReservation.CheckInDate.Date && x.CheckOutDate == webReservation.CheckOutDate.Date && x.RoomID == webReservation.RoomID && x.RegistrationType == RegistrationType.WebRezervasyon && x.ReservationID == id);
                if (boolResult == false)
                {
                    registration = mapper.Map<Registration>(webReservation);
                    registration.RegistrationType = RegistrationType.WebRezervasyon;
                    registration.ID = 0;
                    registration.ReservationID = id;
                    createResult = registrationService.Create(registration);
                    if (createResult.ResultStatus == ResultStatus.Success)
                    {
                        webReservation.ReservationStatus = ReservationStatus.GirisYapildi;
                        webReservationService.Update(webReservation);
                    }
                }
            }
            else
            {
                boolResult = true;
            }

            if (boolResult == false)
            {
                var statusOfRoom = (await statusOfRoomService.GetDefault(x => x.RoomID == registration.RoomID && x.StatusStartDate == registration.CheckInDate.Date && x.StatusEndDate == registration.CheckOutDate.Date && x.RoomStatus == RoomStatus.Rezerve)).FirstOrDefault();
                statusOfRoom.RoomStatus = RoomStatus.Dolu;

                if (createResult.ResultStatus == ResultStatus.Success)
                {
                    TempData["RegistrationResult"] = JsonConvert.SerializeObject(createResult);
                    if (statusOfRoom != null)
                    {
                        statusOfRoomService.Update(statusOfRoom);
                    }
                    //Odanın durumunun doluya çekilmesi.
                    var room = await roomService.GetById(registration.RoomID);
                    room.RoomStatus = RoomStatus.Dolu;
                    roomService.Update(room);

                    var registrationId = (await registrationService.GetDefault(x =>
                            x.CheckInDate == registration.CheckInDate.Date &&
                            x.CheckOutDate == registration.CheckOutDate.Date &&
                            x.RoomID == registration.RoomID &&
                            x.ServicePackID == registration.ServicePackID &&
                            x.RegistrationStatus == RegistrationStatus.GirisYapildi &&
                            x.Status == Status.Active)).OrderByDescending(x => x.ID).FirstOrDefault().ID;

                    return RedirectToAction("RegistrationDetail", new { id = registrationId });
                }
                else
                {
                    TempData["ReservationResult"] = JsonConvert.SerializeObject(createResult);
                    return RedirectToAction("ReservationDetail", "Reservation", new { id = id });
                }
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Rezervasyon zaten kayıtlı.";
                TempData["ReservationResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("Index", "Reservation", new { id = id });
            }
            

        }
        public async Task<IActionResult> CheckOutProcess(int id)
        {
            var registration = await registrationService.GetById(id);
            var useOfExtraServices = registration.UseOfExtraServices.ToList();
            if (registration!=null)
            {
                registration.CheckOutTime = TimeSpan.FromHours(10); //Todo: anlık saat bilgisi alınacak geçici yapıldı.
                registration.RegistrationStatus = RegistrationStatus.CikisYapildi;
                if (registration.ServicePack.PackName=="Tam Pansiyon")
                {
                    registration.Price = incomeService.CalculateIncome(registration); //Ekstra harcama varsa fiyat güncellemesi
                }
                var updateResult = registrationService.Update(registration);
                 
                TempData["RegistrationResult"] = JsonConvert.SerializeObject(updateResult);
                if (updateResult.ResultStatus==ResultStatus.Success && registration.RegistrationType==RegistrationType.ResepsiyonRezervasyon)
                {
                    var reservationId = registration.ReservationID.ToString();
                    var receptionReservation = await receptionReservationService.GetById(int.Parse(reservationId));
                    receptionReservation.ReservationStatus = ReservationStatus.RezervasyonTamamlandi;
                    receptionReservationService.Update(receptionReservation);
                }
                else if (updateResult.ResultStatus == ResultStatus.Success && registration.RegistrationType == RegistrationType.WebRezervasyon)
                {
                    var reservationId = registration.ReservationID.ToString();
                    var webReservation = await webReservationService.GetById(int.Parse(reservationId));
                    webReservation.ReservationStatus = ReservationStatus.RezervasyonTamamlandi;
                    webReservationService.Update(webReservation);
                }
                if (updateResult.ResultStatus == ResultStatus.Success)
                {
                    //Misafirlerin durumunun değiştirilmesi.
                    foreach (var item in registration.GuestRegistrations)
                    {
                        item.Guest.IsActive = false;
                        guestService.Update(item.Guest);
                    }
                    //Çıkış yapıldığında odanın kirli olarak güncellenmesi.
                    var room = await roomService.GetById(registration.RoomID);
                    room.RoomStatus = RoomStatus.Kirli;
                    roomService.Update(room);
                    //Çıkış yapıldığında oda statüsünü doludan boşa çekmek.
                    var statusofRoom = (await statusOfRoomService.GetDefault(x => x.StatusStartDate == registration.CheckInDate.Date && x.StatusEndDate == registration.CheckOutDate.Date && x.RoomID == registration.RoomID && x.RoomStatus==RoomStatus.Dolu)).FirstOrDefault();
                    statusofRoom.RoomStatus = RoomStatus.Bos;
                    statusOfRoomService.Update(statusofRoom);
                    //Gelir kaydı.
                    Income income = new Income();
                    income.TotalPrice = registration.Price;
                    income.RegistrationID = registration.ID;
                    incomeService.Create(income);
                }


                return RedirectToAction("RegistrationDetail", new { id = id });
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Kayıt bulunamadı.";
                TempData["RegistrationResult"] = JsonConvert.SerializeObject(result);
                return RedirectToAction("RegistrationDetail", new { id = id });
            }
        }
        public async Task<IActionResult> AddGuestToRegistration(int registrationId, int guestId)
        {
            if (await registrationService.Any(x=>x.ID==registrationId) && await guestService.Any(x=>x.ID==guestId))
            {
                if (await guestRegistrationService.Any(x=>x.GuestID==guestId && x.RegistrationID==registrationId))
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "İlgili kayıta ait müşteri zaten kayıtlı.";
                    TempData["RegistrationResult"] = JsonConvert.SerializeObject(result);
                }
                else if ((await guestService.GetById(guestId)).IsActive)
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Eklemek istediğiniz müşterini farklı bir kayıtta gözüküyor.";
                    TempData["RegistrationResult"] = JsonConvert.SerializeObject(result);
                }
                else
                {
                    var guest = await guestService.GetById(guestId);
                    guest.IsActive = true;
                    guestService.Update(guest);
                    GuestRegistration guestRegistration = new GuestRegistration();
                    guestRegistration.GuestID = guestId;
                    guestRegistration.RegistrationID = registrationId;
                    var createResult = guestRegistrationService.Create(guestRegistration);
                    TempData["RegistrationResult"] = JsonConvert.SerializeObject(createResult);                    
                }
                return RedirectToAction("RegistrationDetail", new { id = registrationId });
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Kayıt bulunamadı.";
                TempData["RegistrationResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
    }
}
