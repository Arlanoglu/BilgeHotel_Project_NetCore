using AutoMapper;
using Business.Services.Abstract;
using Common;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Guest;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class GuestController : Controller
    {
        private readonly IMapper mapper;
        private readonly IGuestService guestService;
        private readonly IRegistrationService registrationService;
        private readonly IResult result;

        public GuestController(IMapper mapper, IGuestService guestService, IRegistrationService registrationService, IResult result)
        {
            this.mapper = mapper;
            this.guestService = guestService;
            this.registrationService = registrationService;
            this.result = result;
        }

        //Müşterileri listeler. Ancak kayıt tarafından bir müşteri eklemek için listeleme talebi gelirse yani id dolu gelirse ilgili kayıta müşteriyi eklemek için registrationId ile listeleme yapar.
        public async Task<IActionResult> Index(int id)
        {
            if (TempData["GuestResult"] != null)
            {
                var guestResultResult = JsonConvert.DeserializeObject<Result>(TempData["GuestResult"].ToString());
                ViewBag.GuestResult = guestResultResult;
            }
            var guests = await guestService.GetActive();

            ObjectCreator creator = new ObjectCreator();
            var vmguestList = (VMGuestRegistrationSelection)creator.FactoryMethod(ViewModels.VMGuestRegistrationSelection);
            vmguestList.VMGuestLists = mapper.Map<List<VMGuestList>>(guests);
            if (await registrationService.Any(x=>x.ID==id))
            {
                vmguestList.RegistrationID = id;
            }
            return View(vmguestList);
        }
        public async Task<IActionResult> GuestDetail(int id)
        {
            if (TempData["GuestResult"] != null)
            {
                var guestResultResult = JsonConvert.DeserializeObject<Result>(TempData["GuestResult"].ToString());
                ViewBag.GuestResult = guestResultResult;
            }
            var guest = await guestService.GetById(id);
            if (guest!=null)
            {
                var vmGuest = mapper.Map<VMGuestDetail>(guest);
                return View(vmGuest);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Misafir bulunamadı.";
                TempData["GuestResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        public IActionResult AddGuest()
        {
            if (TempData["GuestResult"] != null)
            {
                var guestResultResult = JsonConvert.DeserializeObject<Result>(TempData["GuestResult"].ToString());
                ViewBag.GuestResult = guestResultResult;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuest(VMGuestCreate vMGuestCreate, IFormFile idCardFrontSide, IFormFile idCardBackSide)
        {
            if (ModelState.IsValid)
            {
                if (await guestService.Any(x=>x.IdentificationNumber==vMGuestCreate.IdentificationNumber))
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Kişi zaten kayıtlı.";
                    TempData["GuestResult"] = JsonConvert.SerializeObject(result);
                }
                else
                {
                    var guest = mapper.Map<Guest>(vMGuestCreate);

                    var frondSideResult = ImageUploader.UploadImage("/img/guests/idcards/", idCardFrontSide, (Result)result);
                    guest.IdCardFrontSideImage = frondSideResult.Message;
                    var backSideResult = ImageUploader.UploadImage("/img/guests/idcards/", idCardBackSide, (Result)result);
                    guest.IdCardBackSideImage = backSideResult.Message;

                    if (frondSideResult.ResultStatus==ResultStatus.Success && backSideResult.ResultStatus==ResultStatus.Success)
                    {                     
                        var createResult = guestService.Create(guest);
                        TempData["GuestResult"] = JsonConvert.SerializeObject(createResult);

                        return RedirectToAction("Index");
                    }
                    else if (frondSideResult.ResultStatus == ResultStatus.Error)
                    {
                        TempData["GuestResult"] = JsonConvert.SerializeObject(frondSideResult);
                    }
                    else
                    {
                        TempData["GuestResult"] = JsonConvert.SerializeObject(backSideResult);
                    }
                    
                }
                return RedirectToAction("AddGuest");
            }
            else
            {
                return View();
            }
            
        }
    }
}
