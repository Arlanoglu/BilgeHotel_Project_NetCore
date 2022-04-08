using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IIncomeService : IService<Income>
    {
        public decimal CalculateIncome(Registration registration);
        public decimal DailyIncome(List<Income> incomes, DateTime date);
        public decimal MonthlyIncome(List<Income> incomes, int month, int year);
        public decimal YearlyIncome(List<Income> incomes, int year);
        public decimal TotalIncome(List<Income> incomes);
    }
}
