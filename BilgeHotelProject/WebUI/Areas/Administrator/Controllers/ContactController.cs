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
using WebUI.Models.Contact;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="admin")]
    public class ContactController : Controller
    {
        private readonly IMapper mapper;
        private readonly IContactService contactService;

        public ContactController(IMapper mapper, IContactService contactService)
        {
            this.mapper = mapper;
            this.contactService = contactService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["ContactResult"] != null)
            {
                var contactResult = JsonConvert.DeserializeObject<Result>(TempData["ContactResult"].ToString());
                ViewBag.ContactResult = contactResult;
            }

            var contact = (await contactService.GetActive()).FirstOrDefault();
            var vmContact = mapper.Map<VMContactCreateUpdate>(contact);

            return View(vmContact);
        }
        [HttpPost]
        public IActionResult ContactCreate(VMContactCreateUpdate vMContactCreateUpdate)
        {
            if (ModelState.IsValid)
            {
                var contact = mapper.Map<Contact>(vMContactCreateUpdate);
                var createResult = contactService.Create(contact);

                //TempData["ContactResult"] = JsonConvert.SerializeObject(createResult);

                ViewBag.ContactResult = createResult;
            }
            return View("Index", vMContactCreateUpdate);


        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(VMContactCreateUpdate vMContactCreateUpdate)
        {
            if (ModelState.IsValid)
            {
                var contact = await contactService.GetById(vMContactCreateUpdate.ContactID);
                contact.Adress = vMContactCreateUpdate.Adress;
                contact.Phone1 = vMContactCreateUpdate.Phone1;
                contact.Phone2 = vMContactCreateUpdate.Phone2;
                contact.Fax = vMContactCreateUpdate.Fax;
                contact.Email = vMContactCreateUpdate.Email;
                contact.Facebook = vMContactCreateUpdate.Facebook;
                contact.Instagram = vMContactCreateUpdate.Instagram;
                contact.Twitter = vMContactCreateUpdate.Twitter;

                var updateResult = contactService.Update(contact);
                ViewBag.ContactResult = updateResult;
            }
            return View("Index", vMContactCreateUpdate);
        }
    }
}
