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
    public class RoomManager : IRoomService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public RoomManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<Room, bool>> exp)
        {
            return await unitOfWork.RoomDal.Any(exp);
        }

        public IResult Create(Room model)
        {
            try
            {
                unitOfWork.RoomDal.Create(model);
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
                unitOfWork.RoomDal.Delete(id);
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

        public async Task<List<Room>> GetActive()
        {
            return await unitOfWork.RoomDal.GetActive();
        }

        public async Task<List<Room>> GetAll()
        {
            return await unitOfWork.RoomDal.GetAll();
        }

        public async Task<Room> GetById(int id)
        {
            return await unitOfWork.RoomDal.GetById(id);
        }

        public async Task<List<Room>> GetDefault(Expression<Func<Room, bool>> exp)
        {
            return await unitOfWork.RoomDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.RoomDal.RemoveForce(id);
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

        public IResult Update(Room model)
        {
            try
            {
                unitOfWork.RoomDal.Update(model);
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
        public async Task<Room> GetFirstOrDefault()
        {
            return await unitOfWork.RoomDal.GetFirstOrDefault();
        }

        public async Task<List<Room>> AvaibleRooms(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            return await unitOfWork.RoomDal.AvaibleRooms(checkinDate, checkoutDate, numberOfPeople);
        }
    }
}
