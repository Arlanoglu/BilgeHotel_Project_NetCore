using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Income
{
    public class VMIncomeCombine : BaseVM
    {
        public decimal TotalIncome { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal DailyIncome { get; set; }
        public decimal YearlyIncome { get; set; }
        public List<VMIncome> vMIncomes { get; set; }
    }
}
