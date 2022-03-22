using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomFacility;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;

namespace WebUI.ViewComponents.Room
{
    public class RoomTypeDetail : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IRoomTypeService roomTypeService;
        private readonly IServicePackService servicePackService;

        public RoomTypeDetail(IMapper mapper, IRoomTypeService roomTypeService, IServicePackService servicePackService)
        {
            this.mapper = mapper;
            this.roomTypeService = roomTypeService;
            this.servicePackService = servicePackService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var roomType = await roomTypeService.GetById(id);
            List<VMRoomFacility> vMRoomFacilities = new List<VMRoomFacility>();
            if (roomType.FacilityOfRooms.Count>0)
            {
                foreach (var item in roomType.FacilityOfRooms)
                {
                    var vmRoomFacility = mapper.Map<VMRoomFacility>(item.RoomFacility);
                    vMRoomFacilities.Add(vmRoomFacility);
                }
            }
            var vmRoomType = mapper.Map<VMRoomType>(roomType);
            var vmRoomPictures = mapper.Map<List<VMRoomPicture>>(roomType.RoomPictures);
            vmRoomType.VMRoomFacilities = vMRoomFacilities;
            vmRoomType.VMRoomPictures = vmRoomPictures;

            var servicePacks = await servicePackService.GetActive();
            ViewBag.ServicePacks = mapper.Map<List<VMServicePack>>(servicePacks);

            return View(vmRoomType);
        }
    }
}
