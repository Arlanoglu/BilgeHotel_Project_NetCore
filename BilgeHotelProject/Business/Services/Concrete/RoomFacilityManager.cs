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
    public class RoomFacilityManager : IRoomFacilityService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public RoomFacilityManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<RoomFacility, bool>> exp)
        {
            return await unitOfWork.RoomFacilityDal.Any(exp);
        }

        public IResult Create(RoomFacility model)
        {
            try
            {
                unitOfWork.RoomFacilityDal.Create(model);
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
                unitOfWork.RoomFacilityDal.Delete(id);
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

        public async Task<List<RoomFacility>> GetActive()
        {
            return await unitOfWork.RoomFacilityDal.GetActive();
        }

        public async Task<List<RoomFacility>> GetAll()
        {
            return await unitOfWork.RoomFacilityDal.GetAll();
        }

        public async Task<RoomFacility> GetById(int id)
        {
            return await unitOfWork.RoomFacilityDal.GetById(id);
        }

        public async Task<List<RoomFacility>> GetDefault(Expression<Func<RoomFacility, bool>> exp)
        {
            return await unitOfWork.RoomFacilityDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.RoomFacilityDal.RemoveForce(id);
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

        public IResult Update(RoomFacility model)
        {
            try
            {
                unitOfWork.RoomFacilityDal.Update(model);
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
        public async Task<RoomFacility> GetFirstOrDefault()
        {
            return await unitOfWork.RoomFacilityDal.GetFirstOrDefault();
        }
    }
}
