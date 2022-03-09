using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.HomeIndex;
using WebUI.Models.HomePage;
using WebUI.Models.RoomType;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IHomePageService homePageService;
        private readonly IHomePageSlideService homePageSlideService;
        private readonly IRoomTypeService roomTypeService;
        private readonly IRoomPictureService roomPictureService;

        public HomeController(IMapper mapper, IHomePageService homePageService, IHomePageSlideService homePageSlideService, IRoomTypeService roomTypeService, IRoomPictureService roomPictureService)
        {
            this.mapper = mapper;
            this.homePageService = homePageService;
            this.homePageSlideService = homePageSlideService;
            this.roomTypeService = roomTypeService;
            this.roomPictureService = roomPictureService;
        }

        public async Task<IActionResult> Index()
        {
            var homePage = await homePageService.GetFirstOrDefault();
            var homePageSlides = await homePageSlideService.GetActive();
            var roomPictures = await roomPictureService.GetActive();
            var roomTypes = await roomTypeService.GetActive();

            var vmHomePage = mapper.Map<VMHomePage>(homePage);
            var vmHomePageSlides = mapper.Map<List<VMHomePageSlide>>(homePageSlides);
            var vmRoomPictures = mapper.Map <List<VMRoomPicture>>(roomPictures);
            var vmRoomTypes = mapper.Map <List<VMRoomType>>(roomTypes);

            VMHomeIndex vMHomeIndex = new VMHomeIndex();
            vMHomeIndex.VMHomePage = vmHomePage;
            vMHomeIndex.VMHomePageSlides = vmHomePageSlides;
            vMHomeIndex.VMRoomPictures = vmRoomPictures;
            vMHomeIndex.VMRoomTypes = vmRoomTypes;

            return View();
        }
    }
}
