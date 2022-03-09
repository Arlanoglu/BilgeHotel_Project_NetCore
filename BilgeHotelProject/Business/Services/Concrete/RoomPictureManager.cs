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
    public class RoomPictureManager : IRoomPictureService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public RoomPictureManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }

        public async Task<bool> Any(Expression<Func<RoomPicture, bool>> exp)
        {
            return await unitOfWork.RoomPictureDal.Any(exp);
        }

        public IResult Create(RoomPicture model)
        {
            try
            {
                unitOfWork.RoomPictureDal.Create(model);
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
                unitOfWork.RoomPictureDal.Delete(id);
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

        public async Task<List<RoomPicture>> GetActive()
        {
            return await unitOfWork.RoomPictureDal.GetActive();
        }

        public async Task<List<RoomPicture>> GetAll()
        {
            return await unitOfWork.RoomPictureDal.GetAll(); ;
        }

        public async Task<RoomPicture> GetById(int id)
        {
            return await unitOfWork.RoomPictureDal.GetById(id);
        }

        public async Task<List<RoomPicture>> GetDefault(Expression<Func<RoomPicture, bool>> exp)
        {
            return await unitOfWork.RoomPictureDal.GetDefault(exp);
        }

        public async Task<RoomPicture> GetFirstOrDefault()
        {
            return await unitOfWork.RoomPictureDal.GetFirstOrDefault();
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.RoomPictureDal.RemoveForce(id);
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

        public IResult Update(RoomPicture model)
        {
            try
            {
                unitOfWork.RoomPictureDal.Update(model);
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
