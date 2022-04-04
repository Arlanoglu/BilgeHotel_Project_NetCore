using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Enum;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Room;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class RoomController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomService roomService;
        private readonly IRegistrationService registrationService;
        private readonly IResult result;

        public RoomController(IMapper mapper, IRoomService roomService, IRegistrationService registrationService, IResult result)
        {
            this.mapper = mapper;
            this.roomService = roomService;
            this.registrationService = registrationService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RoomResult"] != null)
            {
                var roomResult = JsonConvert.DeserializeObject<Result>(TempData["RoomResult"].ToString());
                ViewBag.RoomResult = roomResult;
            }
            var rooms = await roomService.GetActive();

            if (rooms.Count > 0)
            {
                var vmRooms = mapper.Map<List<VMRoomList>>(rooms);
                foreach (var item in vmRooms)
                {
                    if (await registrationService.Any(x => x.RoomID == item.ID && x.RegistrationStatus == RegistrationStatus.GirisYapildi))
                    {
                        item.RegistrationID = (await registrationService.GetDefault(x => x.RoomID == item.ID && x.RegistrationStatus == RegistrationStatus.GirisYapildi)).FirstOrDefault().ID;
                    }
                }

                return View(vmRooms);
            }
            return View();

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
        public async Task<IActionResult> UpdateRoom(int id)
        {
            var room = await roomService.GetById(id);
            if (room != null)
            {
                var vmRoom = mapper.Map<VMRoomUpdate>(room);
                return View(vmRoom);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıtlı oda bulunamadı.";
                TempData["RoomResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(VMRoomUpdate vMRoomUpdate)
        {
            var room = await roomService.GetById(vMRoomUpdate.RoomID);
            room.RoomNumber = vMRoomUpdate.RoomNumber;
            room.FloorNumber = vMRoomUpdate.FloorNumber;
            room.Description = vMRoomUpdate.Description;

            var updateResult = roomService.Update(room);

            ViewBag.RoomResult = updateResult;

            return View(vMRoomUpdate);
        }
    }
}
