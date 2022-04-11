using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concrete
{
    public class IncomeManager : IIncomeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public IncomeManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<Income, bool>> exp)
        {
            return await unitOfWork.IncomeDal.Any(exp);
        }

        public IResult Create(Income model)
        {
            try
            {
                unitOfWork.IncomeDal.Create(model);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "İşlem başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                unitOfWork.Dispose();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Error;
                result.Message = "İşlem sırasında bir hata meydana geldi.";
                result.Exception = ex;
                return result;
            }
        }

        public IResult Delete(int id)
        {
            try
            {
                unitOfWork.IncomeDal.Delete(id);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "İşlem başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                unitOfWork.Dispose();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Error;
                result.Message = "İşlem sırasında bir hata meydana geldi.";
                result.Exception = ex;
                return result;
            }
        }

        public async Task<List<Income>> GetActive()
        {
            return await unitOfWork.IncomeDal.GetActive();
        }

        public async Task<List<Income>> GetAll()
        {
            return await unitOfWork.IncomeDal.GetAll();
        }

        public async Task<Income> GetById(int id)
        {
            return await unitOfWork.IncomeDal.GetById(id);
        }

        public async Task<List<Income>> GetDefault(Expression<Func<Income, bool>> exp)
        {
            return await unitOfWork.IncomeDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.IncomeDal.RemoveForce(id);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "İşlem başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Error;
                result.Message = "İşlem sırasında bir hata meydana geldi.";
                result.Exception = ex;
                return result;
            }
        }

        public IResult Update(Income model)
        {
            try
            {
                unitOfWork.IncomeDal.Update(model);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "İşlem başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Error;
                result.Message = "İşlem sırasında bir hata meydana geldi.";
                result.Exception = ex;
                return result;
            }
        }
        public async Task<Income> GetFirstOrDefault()
        {
            return await unitOfWork.IncomeDal.GetFirstOrDefault();
        }

        public decimal CalculateIncome(Registration registration)
        {
            decimal extraServicesPrice = 0;
            foreach (var item in registration.UseOfExtraServices)
            {
                extraServicesPrice += item.ExtraService.Price * item.Quantity;
            }
            return extraServicesPrice + registration.Price;
        }

        public decimal DailyIncome(List<Income> incomes, DateTime date)
        {
            var result = incomes.Where(x => x.IncomeDate.Date.ToString("yyyy-MM-dd") == date.Date.ToString("yyyy-MM-dd")).Select(x => x.TotalPrice).Sum();
            return result;
        }

        public decimal MonthlyIncome(List<Income> incomes, int month, int year)
        {
            var result = incomes.Where(x => x.IncomeDate.Date.Month == month && x.IncomeDate.Date.Year == year).Select(x => x.TotalPrice).Sum();
            return result;
        }

        public decimal YearlyIncome(List<Income> incomes, int year)
        {
            var result = incomes.Where(x => x.IncomeDate.Date.Year == year).Select(x => x.TotalPrice).Sum();
            return result;
        }

        public decimal TotalIncome(List<Income> incomes)
        {
            var result = incomes.Select(x => x.TotalPrice).Sum();
            return result;
        }
    }
}
