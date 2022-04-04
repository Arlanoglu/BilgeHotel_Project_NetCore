using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Enum;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Room;
using Core.Entities.Enum;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Areas.AncillaryServices.Controllers
{
    [Area("AncillaryServices")]
    [Authorize(Roles = "yardimci hizmetler")]
    public class RoomController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomService roomService;

        public RoomController(IMapper mapper, IRoomService roomService)
        {
            this.mapper = mapper;
            this.roomService = roomService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RoomResult"] != null)
            {
                var roomResult = JsonConvert.DeserializeObject<Result>(TempData["RoomResult"].ToString());
                ViewBag.RoomResult = roomResult;
            }
            var rooms = await roomService.GetActive();
            var vmRooms = mapper.Map<List<VMRoomList>>(rooms);

            return View(vmRooms);
        }
        public async Task<IActionResult> ChangeStatusOfRoom(int id, RoomStatus roomStatus)
        {
            var room = await roomService.GetById(id);
            if (room != null)
            {
                room.RoomStatus = roomStatus;
                var updateResult = roomService.Update(room);
                TempData["RoomResult"] = JsonConvert.SerializeObject(updateResult);

            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DirtyRooms()
        {
            if (TempData["RoomResult"] != null)
            {
                var roomResult = JsonConvert.DeserializeObject<Result>(TempData["RoomResult"].ToString());
                ViewBag.RoomResult = roomResult;
            }
            var rooms = (await roomService.GetActive()).Where(x => x.RoomStatus == RoomStatus.Kirli);
            var vmRooms = mapper.Map<List<VMRoomList>>(rooms);

            return View(vmRooms);
        }
        public async Task<IActionResult> RoomsWithCleaning()
        {
            if (TempData["RoomResult"] != null)
            {
                var roomResult = JsonConvert.DeserializeObject<Result>(TempData["RoomResult"].ToString());
                ViewBag.RoomResult = roomResult;
            }
            var rooms = (await roomService.GetActive()).Where(x => x.RoomStatus == RoomStatus.Temizlik);
            var vmRooms = mapper.Map<List<VMRoomList>>(rooms);

            return View(vmRooms);
        }
    }
}
