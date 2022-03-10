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

        public HomeController(IMapper mapper, IHomePageService homePageService, IRoomTypeService roomTypeService, IRoomPictureService roomPictureService)
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
            //var roomPictures = await roomPictureService.GetActive();
            var roomTypes = await roomTypeService.GetActive();

            var vmHomePage = mapper.Map<VMHomePage>(homePage);
            var vmHomePageSlides = mapper.Map<List<VMHomePageSlide>>(homePage.HomePageSlides);

            List<VMRoomType> vmRoomTypes = new List<VMRoomType>();
            foreach (var item in roomTypes)
            {
                var vmRoomPictures = mapper.Map<List<VMRoomPicture>>(item.RoomPictures);
                var vmRoomType = mapper.Map<VMRoomType>(item);
                vmRoomType.VMRoomPictures = vmRoomPictures;
                vmRoomTypes.Add(vmRoomType);
            }

            VMHomeIndex vMHomeIndex = new VMHomeIndex();
            vMHomeIndex.VMHomePage = vmHomePage;
            vMHomeIndex.VMHomePageSlides = vmHomePageSlides;
            vMHomeIndex.VMRoomTypes = vmRoomTypes;

            return View();
        }
    }
}
