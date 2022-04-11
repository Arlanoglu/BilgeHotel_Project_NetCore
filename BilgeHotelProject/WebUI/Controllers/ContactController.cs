using AutoMapper;
using Business.Services.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Contact;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Common;
using Core.Utilities.Results.Abstract;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMapper mapper;
        private readonly IContactService contactService;
        private readonly IMessageService messageService;
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly ISettingService settingService;
        private readonly IResult result;

        public ContactController(IMapper mapper, IContactService contactService, IMessageService messageService, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, ISettingService settingService, IResult result)
        {
            this.mapper = mapper;
            this.contactService = contactService;
            this.messageService = messageService;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.settingService = settingService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            var contact = await contactService.GetActive();
            var vmContact = mapper.Map<VMContact>(contact.FirstOrDefault());
            TempData["vmContact"] = JsonConvert.SerializeObject(vmContact);
            return View(vmContact);
        }

        [HttpPost]
        public async Task<IActionResult> Index(VMMessage vMMessage)
        {
            if (ModelState.IsValid)
            {
                var message = $"İsim Soyisim : {vMMessage.FirstName} {vMMessage.LastName}\n" +
                              $"Eposta : {vMMessage.Email} \n" +
                              $"Telefon No : {vMMessage.PhoneNumber}\n" +
                              $"Konu : {vMMessage.Subject}\n\n" +
                              $"Mesaj : \n\n {vMMessage.MessageContent}";

                var setting = (await settingService.GetActive()).FirstOrDefault();
                var mailResult = MailSender.SendMail("arlanoglumustafa@hotmail.com", "Müşteri İletişim", message, setting); //Todo: gönderilen mesajların karşılanacağı mail adresi değiştirilecek.

                if (mailResult ==1)
                {
                    result.ResultStatus = ResultStatus.Success;
                    result.Message = "Mesajınız başarıyla iletildi. En kısa zamanda tarafınıza dönüş yapılacaktır.";
                    ViewBag.MessageResult = result;
                }
                else
                {
                    result.ResultStatus = ResultStatus.Error;
                    result.Message = "Mesaj gönderiminde hata oluştu.";
                    ViewBag.MessageResult = result;
                }

                #region OldCode
                //if (signInManager.IsSignedIn(User))
                //{
                //    vMMessage.AppUserID = userManager.GetUserId(User);
                //}
                //var message = mapper.Map<Message>(vMMessage);
                //var messageResult = messageService.Create(message);
                //if (messageResult.ResultStatus==ResultStatus.Success)
                //{
                //    ViewBag.MessageSuccess = "Mesajınız başarıyla iletildi.";                    
                //}
                //else
                //{
                //    ModelState.AddModelError("SendMessageError", "Mesaj gönderiminde hata oluştu.");
                //}  
                #endregion
            }
            var vmContact = JsonConvert.DeserializeObject<VMContact>(TempData["vmContact"].ToString());
            TempData.Keep("vmContact");
            return View(vmContact);
        }
    }
}
