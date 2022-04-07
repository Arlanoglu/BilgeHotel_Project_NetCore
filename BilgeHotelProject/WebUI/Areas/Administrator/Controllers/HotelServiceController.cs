using AutoMapper;
using Business.Services.Abstract;
using Common;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.HotelService;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "admin")]
    public class HotelServiceController : Controller
    {
        private readonly IMapper mapper;
        private readonly IHotelServiceService hotelServiceService;
        private readonly IResult result;

        public HotelServiceController(IMapper mapper, IHotelServiceService hotelServiceService, IResult result)
        {
            this.mapper = mapper;
            this.hotelServiceService = hotelServiceService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["ServiceResult"] != null)
            {
                var serviceResult = JsonConvert.DeserializeObject<Result>(TempData["ServiceResult"].ToString());
                ViewBag.ServiceResult = serviceResult;
            }

            var services = await hotelServiceService.GetAll();
            var vmServices = mapper.Map<List<VMHotelService>>(services);

            return View(vmServices);
        }
        public IActionResult ServiceCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ServiceCreate(VMHotelServiceCreate vMHotelServiceCreate, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var uploadResult = ImageUploader.UploadImage("/img/services/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    var pictureUrl = uploadResult.Message;
                    vMHotelServiceCreate.IconPicture = pictureUrl;

                    var service = mapper.Map<HotelService>(vMHotelServiceCreate);
                    var createResult = hotelServiceService.Create(service);

                    TempData["ServiceResult"] = JsonConvert.SerializeObject(createResult);
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.ServiceResult = uploadResult;
                }
            }
            return View(vMHotelServiceCreate);


        }
        public async Task<IActionResult> RemoveForce(int serviceId)
        {
            if (await hotelServiceService.Any(x => x.ID == serviceId))
            {
                var deleteResult = hotelServiceService.RemoveForce(serviceId);
                TempData["ServiceResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["ServiceResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateAboutus(int serviceId)
        {
            if (TempData["ServiceResult"] != null)
            {
                var serviceResult = JsonConvert.DeserializeObject<Result>(TempData["ServiceResult"].ToString());
                ViewBag.ServiceResult = serviceResult;
            }

            var service = await hotelServiceService.GetById(serviceId);
            if (service != null)
            {
                var vmService = mapper.Map<VMHotelServiceUpdate>(service);
                return View(vmService);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["ServiceResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        } //Update Yapılacak
        [HttpPost]
        public async Task<IActionResult> UpdateAboutus(VMHotelServiceUpdate vMHotelServiceUpdate, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var service = await hotelServiceService.GetById(vMHotelServiceUpdate.ServiceID);
                service.ServiceName = vMHotelServiceUpdate.ServiceName;
                service.Description = vMHotelServiceUpdate.Description;

                var uploadResult = ImageUploader.UploadImage("/img/services/", file, (Result)result);
                if (uploadResult.ResultStatus == ResultStatus.Success)
                {
                    service.IconPicture = uploadResult.Message;
                }
                var updateResult = hotelServiceService.Update(service);
                ViewBag.ServiceResult = updateResult;
            }
            return View(vMHotelServiceUpdate);
        }
        public async Task<IActionResult> ChangeStatus(int serviceId)
        {
            var service = await hotelServiceService.GetById(serviceId);
            if (service != null)
            {
                if (service.Status == Status.Active)
                {
                    service.Status = Status.Deleted;
                }
                else if (service.Status == Status.Deleted)
                {
                    service.Status = Status.Active;
                }
                var updateResult = hotelServiceService.Update(service);
                TempData["ServiceResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["ServiceResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");
        }
    }
}
