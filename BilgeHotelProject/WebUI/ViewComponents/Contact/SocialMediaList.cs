using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Contact;

namespace WebUI.ViewComponents.Contact
{
    public class SocialMediaList : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IContactService contactService;

        public SocialMediaList(IMapper mapper, IContactService contactService)
        {
            this.mapper = mapper;
            this.contactService = contactService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMediaList = await contactService.GetActive();
            var vmSocialMedia = mapper.Map<VMSocialMedia>(socialMediaList.FirstOrDefault());
            return View(vmSocialMedia);
        }
    }
}
