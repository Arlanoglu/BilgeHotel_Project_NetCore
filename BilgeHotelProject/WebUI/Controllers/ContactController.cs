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

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMapper mapper;
        private readonly IContactService contactService;
        private readonly IMessageService messageService;
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public ContactController(IMapper mapper, IContactService contactService, IMessageService messageService, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.mapper = mapper;
            this.contactService = contactService;
            this.messageService = messageService;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var contact = await contactService.GetActive();
            var vmContact = mapper.Map<VMContact>(contact.FirstOrDefault());
            TempData["vmContact"] = JsonConvert.SerializeObject(vmContact);
            return View(vmContact);
        }

        [HttpPost]
        public IActionResult Index(VMMessage vMMessage)
        {
            if (ModelState.IsValid)
            {
                if (signInManager.IsSignedIn(User))
                {
                    vMMessage.AppUserID = userManager.GetUserId(User);
                }
                var message = mapper.Map<Message>(vMMessage);
                var messageResult = messageService.Create(message);
                if (messageResult.ResultStatus==ResultStatus.Success)
                {
                    ViewBag.MessageSuccess = "Mesajınız başarıyla iletildi.";                    
                }
                else
                {
                    ModelState.AddModelError("SendMessageError", "Mesaj gönderiminde hata oluştu.");
                }                
            }
            var vmContact = JsonConvert.DeserializeObject<VMContact>(TempData["vmContact"].ToString());
            TempData.Keep("vmContact");
            return View(vmContact);
        }
    }
}
