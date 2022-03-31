using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Shift;
using Core.Entities.Enum;
using Core.Utilities.Results.Abstract;

namespace WebUI.Areas.HumanResources.Controllers
{
    [Area("HumanResources")]
    public class ShiftController : Controller
    {
        private readonly IMapper mapper;
        private readonly IShiftService shiftService;
        private readonly IResult result;

        public ShiftController(IMapper mapper, IShiftService shiftService, IResult result)
        {
            this.mapper = mapper;
            this.shiftService = shiftService;
            this.result = result;
        }    
        public async Task<IActionResult> Index()
        {
            if (TempData["ShiftResult"] != null)
            {
                var shiftResultResult = JsonConvert.DeserializeObject<Result>(TempData["ShiftResult"].ToString());
                ViewBag.ShiftResult = shiftResultResult;
            }
            var shifts = await shiftService.GetAll();
            var vmShifts = mapper.Map<List<VMShiftList>>(shifts);
            return View(vmShifts);
        }
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var shift = await shiftService.GetById(id);
            if (shift!=null)
            {
                if (shift.Status==Status.Active)
                {
                    shift.Status = Status.Deleted;
                }
                else
                {
                    shift.Status = Status.Active;
                }
                var changeResult = shiftService.Update(shift);
                TempData["ShiftResult"] = JsonConvert.SerializeObject(changeResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait vardiya bulunamadı.";
                TempData["ShiftResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveForce(int id)
        {
            
            if (await shiftService.Any(x=>x.ID==id))
            {
                var changeResult = shiftService.RemoveForce(id);
                TempData["ShiftResult"] = JsonConvert.SerializeObject(changeResult);
            }
            else
            {
                result.ResultStatus = ResultStatus.Error;
                result.Message = "İlgili idye ait vardiya bulunamadı.";
                TempData["ShiftResult"] = JsonConvert.SerializeObject(result);
            }
            return RedirectToAction("Index");
        }
    }
}
