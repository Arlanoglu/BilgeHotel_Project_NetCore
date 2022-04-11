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
    public class EmployeeShiftManager : IEmployeeShiftService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public EmployeeShiftManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }

        public async Task<bool> Any(Expression<Func<EmployeeShift, bool>> exp)
        {
            return await unitOfWork.EmployeeShiftDal.Any(exp);
        }

        public IResult Create(EmployeeShift model)
        {
            try
            {
                unitOfWork.EmployeeShiftDal.Create(model);
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
                unitOfWork.EmployeeShiftDal.Delete(id);
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

        public async Task<List<EmployeeShift>> GetActive()
        {
            return await unitOfWork.EmployeeShiftDal.GetActive();
        }

        public async Task<List<EmployeeShift>> GetAll()
        {
            return await unitOfWork.EmployeeShiftDal.GetAll();
        }

        public async Task<EmployeeShift> GetById(int id)
        {
            return await unitOfWork.EmployeeShiftDal.GetById(id);
        }

        public async Task<List<EmployeeShift>> GetDefault(Expression<Func<EmployeeShift, bool>> exp)
        {
            return await unitOfWork.EmployeeShiftDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.EmployeeShiftDal.RemoveForce(id);
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

        public IResult Update(EmployeeShift model)
        {
            try
            {
                unitOfWork.EmployeeShiftDal.Update(model);
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
        public async Task<EmployeeShift> GetFirstOrDefault()
        {
            return await unitOfWork.EmployeeShiftDal.GetFirstOrDefault();
        }
    }
}
