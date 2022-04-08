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

namespace WebUI.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [Authorize(Roles = "muhasebe")]
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

            var incomes = await incomeService.GetActive();
            var vmIncomes = mapper.Map<List<VMIncome>>(incomes);
            incomeCombine.DailyIncome = incomeService.DailyIncome(incomes, DateTime.Now);
            incomeCombine.MonthlyIncome = incomeService.MonthlyIncome(incomes, DateTime.Now.Month, DateTime.Now.Year);
            incomeCombine.YearlyIncome = incomeService.YearlyIncome(incomes, DateTime.Now.Year);
            incomeCombine.TotalIncome = incomeService.TotalIncome(incomes);
            incomeCombine.vMIncomes = vmIncomes;
            return View(incomeCombine);
        }
    }
}
