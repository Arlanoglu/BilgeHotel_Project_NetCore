using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ExtraService;
using WebUI.Utilities;
using WebUI.Utilities.Enums;

namespace WebUI.ViewComponents.ExtraService
{
    public class UseOfExtraService : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IExtraServiceService extraServiceService;

        public UseOfExtraService(IMapper mapper, IExtraServiceService extraServiceService)
        {
            this.mapper = mapper;
            this.extraServiceService = extraServiceService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var extraServices = await extraServiceService.GetActive();
            var vmExtraServices = mapper.Map<List<VMExtraService>>(extraServices);

            ViewBag.ExtraServices = vmExtraServices;
            ObjectCreator creator = new ObjectCreator();
            var vmUseOfExtraServiceCreate = (VMUseOfExtraServiceCreate)creator.FactoryMethod(ViewModels.VMUseOfExtraServiceCreate);
            vmUseOfExtraServiceCreate.RegistrationID = id;
            return View(vmUseOfExtraServiceCreate);
        }
    }
}
