using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Contact;

namespace WebUI.Controllers
{
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
            var contact = await contactService.GetActive();
            var vmContact = mapper.Map<VMContact>(contact.FirstOrDefault());
            return View(vmContact);
        }
    }
}
