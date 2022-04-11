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
    public class GuestRegistrationManager : IGuestRegistrationService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public GuestRegistrationManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<GuestRegistration, bool>> exp)
        {
            return await unitOfWork.GuestRegistrationDal.Any(exp);
        }

        public IResult Create(GuestRegistration model)
        {
            try
            {
                unitOfWork.GuestRegistrationDal.Create(model);
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
                unitOfWork.GuestRegistrationDal.Delete(id);
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

        public async Task<List<GuestRegistration>> GetActive()
        {
            return await unitOfWork.GuestRegistrationDal.GetActive();
        }

        public async Task<List<GuestRegistration>> GetAll()
        {
            return await unitOfWork.GuestRegistrationDal.GetAll();
        }

        public async Task<GuestRegistration> GetById(int id)
        {
            return await unitOfWork.GuestRegistrationDal.GetById(id);
        }

        public async Task<List<GuestRegistration>> GetDefault(Expression<Func<GuestRegistration, bool>> exp)
        {
            return await unitOfWork.GuestRegistrationDal.GetDefault(exp);
        }

        public async Task<GuestRegistration> GetFirstOrDefault()
        {
            return await unitOfWork.GuestRegistrationDal.GetFirstOrDefault();
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.GuestRegistrationDal.RemoveForce(id);
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

        public IResult Update(GuestRegistration model)
        {
            try
            {
                unitOfWork.GuestRegistrationDal.Update(model);
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
    }
}
