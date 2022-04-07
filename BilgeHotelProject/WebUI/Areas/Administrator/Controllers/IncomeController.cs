using AutoMapper;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Income;
using WebUI.Utilities;

namespace WebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize("admin")]
    public class IncomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IIncomeService incomeService;

        public IncomeController(IMapper mapper, IIncomeService incomeService)
        {
            this.mapper = mapper;
            this.incomeService = incomeService;
        }
        public async Task<IActionResult> Index()
        {
            ObjectCreator creator = new ObjectCreator();
            var incomeCombine = (VMIncomeCombine)creator.FactoryMethod(Utilities.Enums.ViewModels.VMIncomeCombine);

            var income = await incomeService.GetActive();
            var vmIncome = mapper.Map<List<VMIncome>>(income);
            incomeCombine.DailyIncome = vmIncome.Where(x => x.IncomeDate.Date.ToString("yyyy-MM-dd") == DateTime.Now.Date.ToString("yyyy-MM-dd")).Select(x => x.TotalPrice).Sum();
            return View();
        }
    }
}
