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
    public class RoomTypeManager : IRoomTypeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public RoomTypeManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<RoomType, bool>> exp)
        {
            return await unitOfWork.RoomTypeDal.Any(exp);
        }

        public async Task<List<RoomType>> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            var rooms = await unitOfWork.RoomDal.AvaibleRooms(checkinDate, checkoutDate, numberOfPeople);
            var roomTypes = await this.GetActive();

            List<RoomType> roomTypesList = new List<RoomType>();
            foreach (var item in roomTypes)
            {
                if (rooms.Any(x => x.RoomTypeID == item.ID))
                {
                    roomTypesList.Add(item);
                }
            }
            return roomTypesList;
        }

        public IResult Create(RoomType model)
        {
            try
            {
                unitOfWork.RoomTypeDal.Create(model);
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
                unitOfWork.RoomTypeDal.Delete(id);
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

        public async Task<List<RoomType>> GetActive()
        {
            return await unitOfWork.RoomTypeDal.GetActive();
        }

        public async Task<List<RoomType>> GetAll()
        {
            return await unitOfWork.RoomTypeDal.GetAll();
        }

        public async Task<RoomType> GetById(int id)
        {
            return await unitOfWork.RoomTypeDal.GetById(id);
        }

        public async Task<List<RoomType>> GetDefault(Expression<Func<RoomType, bool>> exp)
        {
            return await unitOfWork.RoomTypeDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.RoomTypeDal.RemoveForce(id);
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

        public IResult Update(RoomType model)
        {
            try
            {
                unitOfWork.RoomTypeDal.Update(model);
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
        public async Task<RoomType> GetFirstOrDefault()
        {
            return await unitOfWork.RoomTypeDal.GetFirstOrDefault();
        }
    }
}
