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
    public class AboutusManager : IAboutusService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public AboutusManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }

        public async Task<bool> Any(Expression<Func<Aboutus, bool>> exp)
        {
            return await unitOfWork.AboutusDal.Any(exp);
        }

        public IResult Create(Aboutus model)
        {
            try
            {
                unitOfWork.AboutusDal.Create(model);
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
                unitOfWork.AboutusDal.Delete(id);
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

        public async Task<List<Aboutus>> GetActive()
        {
            return await unitOfWork.AboutusDal.GetActive();
        }

        public async Task<List<Aboutus>> GetAll()
        {
            return await unitOfWork.AboutusDal.GetAll();
        }

        public async Task<Aboutus> GetById(int id)
        {
            return await unitOfWork.AboutusDal.GetById(id);
        }

        public async Task<List<Aboutus>> GetDefault(Expression<Func<Aboutus, bool>> exp)
        {
            return await unitOfWork.AboutusDal.GetDefault(exp);
        }

        public async Task<Aboutus> GetFirstOrDefault()
        {
            return await unitOfWork.AboutusDal.GetFirstOrDefault();
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.AboutusDal.RemoveForce(id);
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

        public IResult Update(Aboutus model)
        {
            try
            {
                unitOfWork.AboutusDal.Update(model);
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
    }
}
