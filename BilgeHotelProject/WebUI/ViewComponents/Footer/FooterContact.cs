using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using WebUI.Models.Contact;
using WebUI.Models.RoomType;

namespace WebUI.ViewComponents.Footer
{
    public class FooterContact : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IContactService contactService;

        public FooterContact(IMapper mapper, IContactService contactService)
        {
            this.mapper = mapper;
            this.contactService = contactService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contact = await contactService.GetActive();

            return View(mapper.Map<VMContact>(contact.FirstOrDefault()));
        }
    }
}
