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

        public RegistrationController(IMapper mapper, IRegistrationService registrationService, IUseOfExtraServiceService useOfExtraServiceService, IResult result, IServicePackService servicePackService, IRoomTypeService roomTypeService, IRoomService roomService)
        {
            this.mapper = mapper;
            this.registrationService = registrationService;
            this.useOfExtraServiceService = useOfExtraServiceService;
            this.result = result;
            this.servicePackService = servicePackService;
            this.roomTypeService = roomTypeService;
            this.roomService = roomService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RegistrationResult"] != null)
            {
                var registrationResult = JsonConvert.DeserializeObject<Result>(TempData["RegistrationResult"].ToString());
                ViewBag.RegistrationResult = registrationResult;
            }
            var registrations = await registrationService.GetAll();
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
                            var registrationId = (await registrationService.GetDefault(x =>
                            x.CheckInDate == registration.CheckInDate.Date &&
                            x.CheckOutDate == registration.CheckOutDate.Date &&
                            x.RoomID == registration.RoomID &&
                            x.ServicePackID == registration.ServicePackID &&
                            x.RegistrationStatus == RegistrationStatus.GirisYapildi &&
                            x.Status == Status.Active)).OrderByDescending(x => x.ID).FirstOrDefault().ID;

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
    }
}
