using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomFacility;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.ViewComponents.Room
{
    public class AddFacilityToRoomType : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IRoomFacilityService roomFacilityService;

        public AddFacilityToRoomType(IMapper mapper, IRoomFacilityService roomFacilityService)
        {
            this.mapper = mapper;
            this.roomFacilityService = roomFacilityService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ObjectCreator creator = new ObjectCreator();
            var vmRoomFacilitySelectionCombine = (VMRoomFacilitySelectionCombine)creator.FactoryMethod(ViewModels.VMRoomFacilitySelectionCombine);

            var facilities = await roomFacilityService.GetActive();
            vmRoomFacilitySelectionCombine.RoomTypeID = id;
            vmRoomFacilitySelectionCombine.VMRoomFacilitySelections = mapper.Map<List<VMRoomFacilitySelection>>(facilities);

            return View(vmRoomFacilitySelectionCombine);
        }
    }
}
