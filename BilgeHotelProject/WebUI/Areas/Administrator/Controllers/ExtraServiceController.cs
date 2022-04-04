using AutoMapper;
using Business.Services.Abstract;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ExtraService;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="admin")]
    public class ExtraServiceController : Controller
    {
        private readonly IMapper mapper;
        private readonly IExtraServiceService extraServiceService;
        private readonly IResult result;

        public ExtraServiceController(IMapper mapper, IExtraServiceService extraServiceService, IResult result)
        {
            this.mapper = mapper;
            this.extraServiceService = extraServiceService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["ExtraServiceResult"] != null)
            {
                var extraServiceResult = JsonConvert.DeserializeObject<Result>(TempData["ExtraServiceResult"].ToString());
                ViewBag.ExtraServiceResult = extraServiceResult;
            }
            var extraServices = await extraServiceService.GetAll();
            var vmExtraServices = mapper.Map<List<VMExtraServiceList>>(extraServices);

            return View(vmExtraServices);
        }
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var extraService = await extraServiceService.GetById(id);
            if (extraService != null)
            {
                if (extraService.Status == Status.Active)
                {
                    extraService.Status = Status.Deleted;
                }
                else if (extraService.Status == Status.Deleted)
                {
                    extraService.Status = Status.Active;
                }
                var updateResult = extraServiceService.Update(extraService);
                TempData["ExtraServiceResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["ExtraServiceResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateExtraService(int id)
        {
            if (TempData["ExtraServiceResult"] != null)
            {
                var extraServiceResult = JsonConvert.DeserializeObject<Result>(TempData["ExtraServiceResult"].ToString());
                ViewBag.ExtraServiceResult = extraServiceResult;
            }

            var extraService = await extraServiceService.GetById(id);
            if (extraService != null)
            {
                var vmExtraService = mapper.Map<VMExtraServiceList>(extraService);
                return View(vmExtraService);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["ExtraServiceResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateExtraService(VMExtraServiceList vMExtraServiceList)
        {
            if (ModelState.IsValid)
            {
                var extraService = await extraServiceService.GetById(vMExtraServiceList.ServiceID);
                extraService.ServiceName = vMExtraServiceList.ServiceName;
                extraService.Price = vMExtraServiceList.Price;

                var updateResult = extraServiceService.Update(extraService);
                ViewBag.ExtraServiceResult = updateResult;
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Giriş bilgileri hatalı. Hizmet adı boş olmamalı ve fiyat alanına parasal bir ifade girilmelidir.";
                ViewBag.ExtraServiceResult = result;
            }

            return View(vMExtraServiceList);
        }
        [HttpPost]
        public IActionResult ExtraServiceCreate(VMExtraServiceList vMExtraServiceList)
        {
            if (ModelState.IsValid)
            {
                var extraService = mapper.Map<ExtraService>(vMExtraServiceList);
                var createResult = extraServiceService.Create(extraService);

                TempData["ExtraServiceResult"] = JsonConvert.SerializeObject(createResult);

            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Giriş bilgileri hatalı. Hizmet adı boş olmamalı ve fiyat alanına parasal bir ifade girilmelidir.";
                TempData["ExtraServiceResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");

        }
    }
}
