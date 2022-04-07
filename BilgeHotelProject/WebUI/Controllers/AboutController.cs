using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Aboutus;
using WebUI.Models.Picture;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IMapper mapper;
        private readonly IAboutusService aboutusService;

        public AboutController(IMapper mapper, IAboutusService aboutusService)
        {
            this.mapper = mapper;
            this.aboutusService = aboutusService;
        }
        public async Task<IActionResult> Index()
        {
            var aboutus = await aboutusService.GetActive();
            var vmAboutus = mapper.Map<VMAboutus>(aboutus.FirstOrDefault());
            if (vmAboutus != null)
            {
                vmAboutus.VMPictures = mapper.Map<List<VMPicture>>(aboutus.FirstOrDefault().Pictures);
            }
            return View(vmAboutus);
        }
    }
}
