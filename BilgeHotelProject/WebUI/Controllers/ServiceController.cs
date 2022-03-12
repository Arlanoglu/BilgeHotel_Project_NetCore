using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.HotelService;

namespace WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IMapper mapper;
        private readonly IHotelServiceService hotelServiceService;

        public ServiceController(IMapper mapper, IHotelServiceService hotelServiceService)
        {
            this.mapper = mapper;
            this.hotelServiceService = hotelServiceService;
        }
        public async Task<IActionResult> Index()
        {
            var hotelService = await hotelServiceService.GetActive();
            var vmHotelService = mapper.Map<List<VMHotelService>>(hotelService);
            return View(vmHotelService);
        }
    }
}
