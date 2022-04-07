using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Setting;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="admin")]
    public class SettingController : Controller
    {
        private readonly IMapper mapper;
        private readonly ISettingService settingService;

        public SettingController(IMapper mapper, ISettingService settingService)
        {
            this.mapper = mapper;
            this.settingService = settingService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["SettingResult"] != null)
            {
                var settingResult = JsonConvert.DeserializeObject<Result>(TempData["SettingResult"].ToString());
                ViewBag.SettingResult = settingResult;
            }

            var setting = (await settingService.GetActive()).FirstOrDefault();
            var vmSetting = mapper.Map<VMSettingCreateUpdate>(setting);

            return View(vmSetting);
        }
        [HttpPost]
        public IActionResult SettingCreate(VMSettingCreateUpdate vMSettingCreateUpdate)
        {
            if (ModelState.IsValid)
            {
                var setting = mapper.Map<Setting>(vMSettingCreateUpdate);
                var createResult = settingService.Create(setting);

                ViewBag.SettingResult = createResult;
            }
            return View("Index", vMSettingCreateUpdate);


        }
        [HttpPost]
        public async Task<IActionResult> UpdateSetting(VMSettingCreateUpdate vMSettingCreateUpdate)
        {
            if (ModelState.IsValid)
            {
                var setting = await settingService.GetById(vMSettingCreateUpdate.SettingID);
                setting.SmtpHost = vMSettingCreateUpdate.SmtpHost;
                setting.SmtpPort = vMSettingCreateUpdate.SmtpPort;
                setting.SmtpEmail = vMSettingCreateUpdate.SmtpEmail;
                setting.SmtpPassword = vMSettingCreateUpdate.SmtpPassword;

                var updateResult = settingService.Update(setting);
                ViewBag.SettingResult = updateResult;
            }
            return View("Index", vMSettingCreateUpdate);
        }
    }
}
