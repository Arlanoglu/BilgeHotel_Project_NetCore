using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomType;
using Core.Entities.Enum;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Common;
using WebUI.Models.RoomFacility;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "admin")]
    public class RoomTypeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRoomTypeService roomTypeService;
        private readonly IRoomPictureService roomPictureService;
        private readonly IResult result;
        private readonly IFacilityOfRoomService facilityOfRoomService;
        private readonly IRoomFacilityService roomFacilityService;

        public RoomTypeController(IMapper mapper, IRoomTypeService roomTypeService, IRoomPictureService roomPictureService, IResult result, IFacilityOfRoomService facilityOfRoomService, IRoomFacilityService roomFacilityService)
        {
            this.mapper = mapper;
            this.roomTypeService = roomTypeService;
            this.roomPictureService = roomPictureService;
            this.result = result;
            this.facilityOfRoomService = facilityOfRoomService;
            this.roomFacilityService = roomFacilityService;
        }
        public async Task<IActionResult> Index()
        {
            if (TempData["RoomTypeResult"]!=null)
            {
                var roomTypeResult = JsonConvert.DeserializeObject<Result>(TempData["RoomTypeResult"].ToString());
                ViewBag.RoomTypeResult = roomTypeResult;
            }
            var roomTypes = await roomTypeService.GetAll();
            var vmRoomTypes = mapper.Map<List<VMRoomType>>(roomTypes);
            return View(vmRoomTypes);
        }
        public async Task<IActionResult> Deactivate(int id)
        {
            if (await roomTypeService.Any(x => x.ID == id))
            {
                var deleteResult = roomTypeService.Delete(id);

                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(deleteResult);
            }            

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int id)
        {
            var roomType = await roomTypeService.GetById(id);
            if (roomType!=null && roomType.Status!=Status.Active)
            {
                roomType.Status = Status.Active;
                var updateResult = roomTypeService.Update(roomType);

                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(updateResult);

            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveForce(int id)
        {
            if (await roomTypeService.Any(x => x.ID == id))
            {
                if ((await roomTypeService.GetById(id)).RoomPictures.Count>0)
                {
                    var value = false;
                    foreach (var item in (await roomTypeService.GetById(id)).RoomPictures)
                    {
                        var roomPictureResult = roomPictureService.RemoveForce(item.ID);
                        if (roomPictureResult.ResultStatus == ResultStatus.Success)
                            value = true;
                        else
                            value = false;
                    }
                    if (value)
                    {
                        var deleteResult = roomTypeService.RemoveForce(id);

                        TempData["RoomTypeResult"] = JsonConvert.SerializeObject(deleteResult);
                    }
                    else
                    {
                        result.ResultStatus = ResultStatus.Error;
                        result.Message = "Oda tipine ait kayıtlı görseller olduğu için veri silinemedi. Önce ilgili oda tipine ait görselleri silmeyi deneyebilirsiniz.";
                        TempData["RoomTypeResult"] = JsonConvert.SerializeObject(result);
                    }
                }
                else
                {
                    var deleteResult = roomTypeService.RemoveForce(id);

                    TempData["RoomTypeResult"] = JsonConvert.SerializeObject(deleteResult);
                }
                

                
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            if (TempData["RoomTypeResult"] != null)
            {
                var roomTypeResult = JsonConvert.DeserializeObject<Result>(TempData["RoomTypeResult"].ToString());
                ViewBag.RoomTypeResult = roomTypeResult;
            }
            var roomType = await roomTypeService.GetById(id);
            if (roomType!=null)
            {
                var vmRoomType = mapper.Map<VMRoomType>(roomType);
                return View(vmRoomType);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpPost]
        public IActionResult Update(VMRoomType vMRoomType)
        {
            if (ModelState.IsValid)
            {
                var roomType = mapper.Map<RoomType>(vMRoomType);
                var updateResult = roomTypeService.Update(roomType);

                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(updateResult);

                return RedirectToAction("Index");
            }
            else
            {
                return View(vMRoomType);
            }
            
        }
        public IActionResult RoomTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RoomTypeCreate(VMRoomType vMRoomType)
        {
            if (ModelState.IsValid)
            {
                var roomType = mapper.Map<RoomType>(vMRoomType);
                var createResult = roomTypeService.Create(roomType);

                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(createResult);

                return RedirectToAction("Index");
            }
            else
            {
                return View(vMRoomType);
            }
        }
        public async Task<IActionResult> Pictures(int id)
        {
            if (TempData["PictureResult"] != null)
            {
                var roomTypeResult = JsonConvert.DeserializeObject<Result>(TempData["PictureResult"].ToString());
                ViewBag.PictureResult = roomTypeResult;
            }
            if (await roomTypeService.Any(x=>x.ID==id))
            {
                var pictures = await roomPictureService.GetDefault(x => x.RoomTypeID == id);
                var vmRoomPictures = mapper.Map<List<VMRoomPicture>>(pictures);
                ViewBag.RoomTypeId = id;
                return View(vmRoomPictures);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpPost]
        public IActionResult PictureUpload(VMRoomPicture vMRoomPicture, IFormFile file)
        {
            var uploadResult = ImageUploader.UploadImage("/img/roomtypes/", file, (Result)result);
            if (uploadResult.ResultStatus==ResultStatus.Success)
            {
                var pictureUrl = uploadResult.Message;
                vMRoomPicture.PictureUrl = pictureUrl;

                var roomPicture = mapper.Map<RoomPicture>(vMRoomPicture);
                var imageCreateResult = roomPictureService.Create(roomPicture);

                TempData["PictureResult"] = JsonConvert.SerializeObject(imageCreateResult);
            }
            else
            {
                TempData["PictureResult"] = JsonConvert.SerializeObject(uploadResult);
            }
            return RedirectToAction("Pictures", new { id= vMRoomPicture.RoomTypeID });
        }
        public async Task<IActionResult> PictureDeActivate(int id)
        {
            var roomTypeId = (await roomPictureService.GetDefault(x => x.ID == id)).FirstOrDefault().RoomTypeID;
            if (await roomPictureService.Any(x=>x.ID==id))
            {
                var deleteResult = roomPictureService.Delete(id);

                TempData["PictureResult"] = JsonConvert.SerializeObject(deleteResult);
            }

            return RedirectToAction("Pictures", new { id = roomTypeId });
        }
        public async Task<IActionResult> PictureActivate(int id)
        {
            var roomPicture = await roomPictureService.GetById(id);
            if (roomPicture != null && roomPicture.Status != Status.Active)
            {
                roomPicture.Status = Status.Active;
                var updateResult = roomPictureService.Update(roomPicture);

                TempData["PictureResult"] = JsonConvert.SerializeObject(updateResult);

            }
            return RedirectToAction("Pictures", new { id = roomPicture.RoomTypeID });
        }

        public async Task<IActionResult> PictureRemoveForce(int id)
        {
            var roomTypeId = (await roomPictureService.GetDefault(x => x.ID == id)).FirstOrDefault().RoomTypeID;
            if (await roomPictureService.Any(x => x.ID == id))
            {
                var deleteResult = roomPictureService.RemoveForce(id);

                TempData["PictureResult"] = JsonConvert.SerializeObject(deleteResult);
            }

            return RedirectToAction("Pictures", new { id = roomTypeId });
        }

        [HttpPost]
        public async Task<IActionResult> RoomTypeRoleSelection(VMRoomFacilitySelectionCombine vMRoomFacilitySelectionCombine)
        {
            var roomtypeFacilities = (await roomTypeService.GetById(vMRoomFacilitySelectionCombine.RoomTypeID)).FacilityOfRooms.ToList();
            var selectedFacilities = vMRoomFacilitySelectionCombine.VMRoomFacilitySelections.Where(x => x.Selected == true).ToList();
            var query = selectedFacilities.Where(x => roomtypeFacilities.Any(r => r.RoomFacilityID == x.FacilityID) == false).ToList();

            var facilityOfRooms = mapper.Map<List<FacilityOfRoom>>(query);
            foreach (var item in facilityOfRooms)
            {
                item.RoomTypeID = vMRoomFacilitySelectionCombine.RoomTypeID;
            }
            var createResult = facilityOfRoomService.Create(facilityOfRooms);
            TempData["RoomTypeResult"] = JsonConvert.SerializeObject(createResult);

            return RedirectToAction("RoomTypeDetail", new { id = vMRoomFacilitySelectionCombine.RoomTypeID });
        }
        public async Task<IActionResult> DeleteRoomFacility(int roomTypeId, int facilityId)
        {
            var facilityOfRoom = (await facilityOfRoomService.GetDefault(x => x.RoomTypeID == roomTypeId && x.RoomFacilityID == facilityId)).FirstOrDefault();

            if (facilityOfRoom != null)
            {
                var deleteResult = facilityOfRoomService.RemoveForce(facilityOfRoom);
                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(deleteResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(result);
            }

            return RedirectToAction("RoomTypeDetail", new { id = roomTypeId });
        }
        public async Task<IActionResult> RoomTypeDetail(int id)
        {
            if (TempData["RoomTypeResult"] != null)
            {
                var roomTypeResult = JsonConvert.DeserializeObject<Result>(TempData["RoomTypeResult"].ToString());
                ViewBag.RoomTypeResult = roomTypeResult;
            }
            var roomType = await roomTypeService.GetById(id);
            if (roomType != null)
            {
                var roomfacilities = await roomFacilityService.GetActive();
                var vmRoomType = mapper.Map<VMRoomTypeDetail>(roomType);

                var query = roomfacilities.Where(x => roomType.FacilityOfRooms.Any(f => f.RoomFacilityID == x.ID)).ToList();

                vmRoomType.VMRoomFacilities = mapper.Map<List<VMRoomFacility>>(query);
                return View(vmRoomType);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait kayıt bulunamadı.";
                TempData["RoomTypeResult"] = JsonConvert.SerializeObject(result);

                return RedirectToAction("Index");
            }
        }
    }
}
