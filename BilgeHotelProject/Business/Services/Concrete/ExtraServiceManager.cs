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
    public class ExtraServiceManager : IExtraServiceService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public ExtraServiceManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<ExtraService, bool>> exp)
        {
            return await unitOfWork.ExtraServiceDal.Any(exp);
        }

        public IResult Create(ExtraService model)
        {
            try
            {
                unitOfWork.ExtraServiceDal.Create(model);
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
                unitOfWork.ExtraServiceDal.Delete(id);
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

        public async Task<List<ExtraService>> GetActive()
        {
            return await unitOfWork.ExtraServiceDal.GetActive();
        }

        public async Task<List<ExtraService>> GetAll()
        {
            return await unitOfWork.ExtraServiceDal.GetAll();
        }

        public async Task<ExtraService> GetById(int id)
        {
            return await unitOfWork.ExtraServiceDal.GetById(id);
        }

        public async Task<List<ExtraService>> GetDefault(Expression<Func<ExtraService, bool>> exp)
        {
            return await unitOfWork.ExtraServiceDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.ExtraServiceDal.RemoveForce(id);
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

        public IResult Update(ExtraService model)
        {
            try
            {
                unitOfWork.ExtraServiceDal.Update(model);
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

        public async Task<ExtraService> GetFirstOrDefault()
        {
            return await unitOfWork.ExtraServiceDal.GetFirstOrDefault();
        }
    }
}
