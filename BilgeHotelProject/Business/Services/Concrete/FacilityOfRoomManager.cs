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
    public class FacilityOfRoomManager : IFacilityOfRoomService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public FacilityOfRoomManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<FacilityOfRoom, bool>> exp)
        {
            return await unitOfWork.FacilityOfRoomDal.Any(exp);
        }

        public IResult Create(FacilityOfRoom model)
        {
            try
            {
                unitOfWork.FacilityOfRoomDal.Create(model);
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
                unitOfWork.FacilityOfRoomDal.Delete(id);
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

        public async Task<List<FacilityOfRoom>> GetActive()
        {
            return await unitOfWork.FacilityOfRoomDal.GetActive();
        }

        public async Task<List<FacilityOfRoom>> GetAll()
        {
            return await unitOfWork.FacilityOfRoomDal.GetAll();
        }

        public async Task<FacilityOfRoom> GetById(int id)
        {
            return await unitOfWork.FacilityOfRoomDal.GetById(id);
        }

        public async Task<List<FacilityOfRoom>> GetDefault(Expression<Func<FacilityOfRoom, bool>> exp)
        {
            return await unitOfWork.FacilityOfRoomDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.FacilityOfRoomDal.RemoveForce(id);
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

        public IResult Update(FacilityOfRoom model)
        {
            try
            {
                unitOfWork.FacilityOfRoomDal.Update(model);
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
        public async Task<FacilityOfRoom> GetFirstOrDefault()
        {
            return await unitOfWork.FacilityOfRoomDal.GetFirstOrDefault();
        }
    }
}
