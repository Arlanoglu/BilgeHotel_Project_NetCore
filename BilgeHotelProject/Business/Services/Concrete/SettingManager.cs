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
    public class SettingManager : ISettingService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public SettingManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }

        public async Task<bool> Any(Expression<Func<Setting, bool>> exp)
        {
            return await unitOfWork.SettingDal.Any(exp);
        }

        public IResult Create(Setting model)
        {
            try
            {
                unitOfWork.SettingDal.Create(model);
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
                unitOfWork.SettingDal.Delete(id);
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

        public async Task<List<Setting>> GetActive()
        {
            return await unitOfWork.SettingDal.GetActive();
        }

        public async Task<List<Setting>> GetAll()
        {
            return await unitOfWork.SettingDal.GetAll();
        }

        public async Task<Setting> GetById(int id)
        {
            return await unitOfWork.SettingDal.GetById(id);
        }

        public async Task<List<Setting>> GetDefault(Expression<Func<Setting, bool>> exp)
        {
            return await unitOfWork.SettingDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.SettingDal.RemoveForce(id);
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

        public IResult Update(Setting model)
        {
            try
            {
                unitOfWork.SettingDal.Update(model);
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
        public async Task<Setting> GetFirstOrDefault()
        {
            return await unitOfWork.SettingDal.GetFirstOrDefault();
        }
    }
}
