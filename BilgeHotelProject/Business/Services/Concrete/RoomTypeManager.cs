﻿using Business.Services.Abstract;
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

        public Task<List<RoomType>> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople)
        {
            return unitOfWork.RoomTypeDal.AvaibleRoomTypes(checkinDate, checkoutDate, numberOfPeople);
            //Todo: Eğer bu katmana EFCore yüklenirse bu metot içerisindeki işlemler burda yapılacak.
        }

        public IResult Create(RoomType model)
        {
            try
            {
                unitOfWork.RoomTypeDal.Create(model);
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
                unitOfWork.RoomTypeDal.Delete(id);
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

        public IResult Update(RoomType model)
        {
            try
            {
                unitOfWork.RoomTypeDal.Update(model);
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
