using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Room;
using Entities.Enum;
using Entities.Concrete;

namespace WebUI.Areas.Reception.Controllers
{
    [Area("Reception")]
    public class RoomController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomService roomService;
        private readonly IRegistrationService registrationService;

        public RoomController(IMapper mapper, IRoomService roomService, IRegistrationService registrationService)
        {
            this.mapper = mapper;
            this.roomService = roomService;
            this.registrationService = registrationService;
        }
        public async Task<IActionResult> Index()
        {
            var rooms = await roomService.GetActive();

            if (rooms.Count>0)
            {
                var vmRooms = mapper.Map<List<VMRoomList>>(rooms);
                foreach (var item in vmRooms)
                {
                    if (await registrationService.Any(x=>x.RoomID==item.ID && x.RegistrationStatus==RegistrationStatus.GirisYapildi))
                    {
                        item.RegistrationID = (await registrationService.GetDefault(x => x.RoomID == item.ID && x.RegistrationStatus == RegistrationStatus.GirisYapildi)).FirstOrDefault().ID;
                    }
                }

                return View(vmRooms);
            }
            return View();
            
        }
    }
}
