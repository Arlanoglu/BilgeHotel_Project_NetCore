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
using Entities.Enum;

namespace Business.Services.Concrete
{
    public class SalaryManager : ISalaryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public SalaryManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<Salary, bool>> exp)
        {
            return await unitOfWork.SalaryDal.Any(exp);
        }

        public IResult Create(Salary model)
        {
            try
            {
                unitOfWork.SalaryDal.Create(model);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Oluşturma işlemi başarıyla gerçekleştirildi.";
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
                unitOfWork.SalaryDal.Delete(id);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
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

        public async Task<List<Salary>> GetActive()
        {
            return await unitOfWork.SalaryDal.GetActive();
        }

        public async Task<List<Salary>> GetAll()
        {
            return await unitOfWork.SalaryDal.GetAll();
        }

        public async Task<Salary> GetById(int id)
        {
            return await unitOfWork.SalaryDal.GetById(id);
        }

        public async Task<List<Salary>> GetDefault(Expression<Func<Salary, bool>> exp)
        {
            return await unitOfWork.SalaryDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.SalaryDal.RemoveForce(id);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
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

        public IResult Update(Salary model)
        {
            try
            {
                unitOfWork.SalaryDal.Update(model);
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Güncelleme işlemi başarıyla gerçekleştirildi.";
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
        public async Task<Salary> GetFirstOrDefault()
        {
            return await unitOfWork.SalaryDal.GetFirstOrDefault();
        }

        public decimal CalculateSalary(List<WorkSchedule> workSchedules)
        {
            decimal salary = 0;

            foreach (var item in workSchedules)
            {
                if (item.WorkStatus==WorkStatus.Calisti)
                {
                    if (item.Employee.MonthlySalary != 0)
                    {
                        salary += item.Employee.MonthlySalary;
                    }
                    else
                    {
                        decimal total = 0;
                        decimal overtimeAmount = 0;
                        if (item.HaveOverTime)
                        {
                            overtimeAmount = item.Employee.OvertimePay * item.OverTimeHour.Hours;
                            total = (item.TotalWorkTime.Hours * item.Employee.HourlyRate) + overtimeAmount;
                        }
                        else
                        {
                            total = (item.TimesWorked.Hours * item.Employee.HourlyRate);
                        }
                        salary += total;
                    }
                }
                else if (item.WorkStatus == WorkStatus.HaftalikIzin || item.WorkStatus == WorkStatus.ResmiTatilIzini || item.WorkStatus == WorkStatus.YillikIzin)
                {
                    salary += (item.TotalWorkTime.Hours * item.Employee.HourlyRate);
                }
            }
            return salary;            
            
        }
    }
}
