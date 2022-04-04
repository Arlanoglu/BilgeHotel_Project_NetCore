using AutoMapper;
using Business.Services.Abstract;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ServicePack;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class ServicePackController : Controller
    {
        private readonly IMapper mapper;
        private readonly IServicePackService servicePackService;
        private readonly IResult result;

        public ServicePackController(IMapper mapper, IServicePackService servicePackService, IResult result)
        {
            this.mapper = mapper;
            this.servicePackService = servicePackService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["ServicePackResult"] != null)
            {
                var servicePackResult = JsonConvert.DeserializeObject<Result>(TempData["ServicePackResult"].ToString());
                ViewBag.ServicePackResult = servicePackResult;
            }
            var servicePacks = await servicePackService.GetAll();
            var vmServicePacks = mapper.Map<List<VMServicePackList>>(servicePacks);

            return View(vmServicePacks);
        }
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var servicePack = await servicePackService.GetById(id);
            if (servicePack != null)
            {
                if (servicePack.Status == Status.Active)
                {
                    servicePack.Status = Status.Deleted;
                }
                else if (servicePack.Status == Status.Deleted)
                {
                    servicePack.Status = Status.Active;
                }
                var updateResult = servicePackService.Update(servicePack);
                TempData["ServicePackResult"] = JsonConvert.SerializeObject(updateResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["ServicePackResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateServicePack(int id)
        {
            if (TempData["ServicePackResult"] != null)
            {
                var servicePackResult = JsonConvert.DeserializeObject<Result>(TempData["ServicePackResult"].ToString());
                ViewBag.ServicePackResult = servicePackResult;
            }

            var servicePack = await servicePackService.GetById(id);
            if (servicePack != null)
            {
                var vmServicePack = mapper.Map<VMServicePackUpdate>(servicePack);
                return View(vmServicePack);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı";
                TempData["ServicePackResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateServicePack(VMServicePackUpdate vMServicePackUpdate)
        {
            if (ModelState.IsValid)
            {
                var servicePack = await servicePackService.GetById(vMServicePackUpdate.ServicePackID);
                servicePack.PackName = vMServicePackUpdate.PackName;
                servicePack.PackPrice = vMServicePackUpdate.PackPrice;
                servicePack.Description = vMServicePackUpdate.Description;

                var updateResult = servicePackService.Update(servicePack);
                ViewBag.ServicePackResult = updateResult;
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Giriş bilgileri hatalı. Hizmet paketi adı boş olmamalı ve fiyat alanına parasal bir ifade girilmelidir.";
                ViewBag.ServicePackResult = result;
            }

            return View(vMServicePackUpdate);
        }
        [HttpPost]
        public IActionResult ServicePackCreate(VMServicePackCreate vMServicePackCreate)
        {
            if (ModelState.IsValid)
            {
                var servicePack = mapper.Map<ServicePack>(vMServicePackCreate);
                var createResult = servicePackService.Create(servicePack);

                TempData["ServicePackResult"] = JsonConvert.SerializeObject(createResult);

            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Giriş bilgileri hatalı. Hizmet paketi adı boş olmamalı ve fiyat alanına parasal bir ifade girilmelidir.";
                TempData["ServicePackResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("Index");

        }
    }
}
