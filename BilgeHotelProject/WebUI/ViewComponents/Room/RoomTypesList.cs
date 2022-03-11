using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomType;

namespace WebUI.ViewComponents.Room
{
    public class RoomTypesList : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IRoomTypeService roomTypeService;

        public RoomTypesList(IMapper mapper, IRoomTypeService roomTypeService)
        {
            this.mapper = mapper;
            this.roomTypeService = roomTypeService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roomTypes = await roomTypeService.GetActive();
            var vmRoomTypes = mapper.Map<List<VMRoomTypeName>>(roomTypes);
            return View(vmRoomTypes);
        }
    }
}
