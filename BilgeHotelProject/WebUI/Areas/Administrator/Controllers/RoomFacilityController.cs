using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomFacility;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "admin")]
    public class RoomFacilityController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomFacilityService roomFacilityService;
        private readonly IResult result;

        public RoomFacilityController(IMapper mapper, IRoomFacilityService roomFacilityService, IResult result)
        {
            this.mapper = mapper;
            this.roomFacilityService = roomFacilityService;
            this.result = result;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RoomFacilityResult"] != null)
            {
                var roomFacilityResult = JsonConvert.DeserializeObject<Result>(TempData["RoomFacilityResult"].ToString());
                ViewBag.RoomFacilityResult = roomFacilityResult;
            }

            var roomFacilities = await roomFacilityService.GetAll();
            var vmRoomFacilities = mapper.Map<List<VMRoomFacility>>(roomFacilities);

            return View(vmRoomFacilities);
        }
        [HttpPost]
        public IActionResult RoomFacilityCreate(VMRoomFacility vMRoomFacility)
        {
            if (vMRoomFacility.FacilityName!=null)
            {
                var roomFacility = mapper.Map<RoomFacility>(vMRoomFacility);
                var createResult = roomFacilityService.Create(roomFacility);

                TempData["RoomFacilityResult"] = JsonConvert.SerializeObject(createResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Olanak adı boş bırakılamaz.";
                TempData["RoomFacilityResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveForce(int id)
        {
            if (await roomFacilityService.Any(x=>x.ID==id))
            {
                var deleteResult = roomFacilityService.RemoveForce(id);
                TempData["RoomFacilityResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["RoomFacilityResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateRoomFacility(int id)
        {
            if (TempData["RoomFacilityResult"] != null)
            {
                var roomFacilityResult = JsonConvert.DeserializeObject<Result>(TempData["RoomFacilityResult"].ToString());
                ViewBag.RoomFacilityResult = roomFacilityResult;
            }

            var roomFacility = await roomFacilityService.GetById(id);
            if (roomFacility != null)
            {
                var vmFacility = mapper.Map<VMRoomFacility>(roomFacility);
                return View(vmFacility);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["RoomFacilityResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoomFacility(VMRoomFacility vMRoomFacility)
        {
            if (vMRoomFacility.FacilityName != null)
            {
                var roomFacility = await roomFacilityService.GetById(vMRoomFacility.ID);
                roomFacility.FacilityName = vMRoomFacility.FacilityName;
                roomFacility.Description = vMRoomFacility.Description;

                var updateResult = roomFacilityService.Update(roomFacility);
                ViewBag.RoomFacilityResult = updateResult;

                
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "Olanak adı boş bırakılamaz.";
                ViewBag.RoomFacilityResult = result;
            }
            return View(vMRoomFacility);
        }
    }
}
