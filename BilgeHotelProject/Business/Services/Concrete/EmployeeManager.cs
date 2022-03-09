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
    public class EmployeeManager : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public EmployeeManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }

        public async Task<bool> Any(Expression<Func<Employee, bool>> exp)
        {
            return await unitOfWork.EmployeeDal.Any(exp);
        }

        public IResult Create(Employee model)
        {
            try
            {
                unitOfWork.EmployeeDal.Create(model);
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
                unitOfWork.EmployeeDal.Delete(id);
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

        public async Task<List<Employee>> GetActive()
        {
            return await unitOfWork.EmployeeDal.GetActive();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await unitOfWork.EmployeeDal.GetAll();
        }

        public async Task<Employee> GetById(int id)
        {
            return await unitOfWork.EmployeeDal.GetById(id);
        }

        public async Task<List<Employee>> GetDefault(Expression<Func<Employee, bool>> exp)
        {
            return await unitOfWork.EmployeeDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.EmployeeDal.RemoveForce(id);
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

        public IResult Update(Employee model)
        {
            try
            {
                unitOfWork.EmployeeDal.Update(model);
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
        public async Task<Employee> GetFirstOrDefault()
        {
            return await unitOfWork.EmployeeDal.GetFirstOrDefault();
        }
    }
}
