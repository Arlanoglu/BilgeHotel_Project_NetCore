using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.UnitOfWork;
using Entities.Concrete;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concrete
{
    public class ReceptionReservationManager : IReceptionReservationService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public ReceptionReservationManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<ReceptionReservation, bool>> exp)
        {
            return await unitOfWork.ReceptionReservationDal.Any(exp);
        }

        public IResult Create(ReceptionReservation model)
        {
            try
            {
                unitOfWork.ReceptionReservationDal.Create(model);
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
                unitOfWork.ReceptionReservationDal.Delete(id);
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

        public async Task<List<ReceptionReservation>> GetActive()
        {
            return await unitOfWork.ReceptionReservationDal.GetActive();
        }

        public async Task<List<ReceptionReservation>> GetAll()
        {
            return await unitOfWork.ReceptionReservationDal.GetAll();
        }

        public async Task<ReceptionReservation> GetById(int id)
        {
            return await unitOfWork.ReceptionReservationDal.GetById(id);
        }

        public async Task<List<ReceptionReservation>> GetDefault(Expression<Func<ReceptionReservation, bool>> exp)
        {
            return await unitOfWork.ReceptionReservationDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.ReceptionReservationDal.RemoveForce(id);
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

        public IResult Update(ReceptionReservation model)
        {
            try
            {
                unitOfWork.ReceptionReservationDal.Update(model);
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
        public async Task<ReceptionReservation> GetFirstOrDefault()
        {
            return await unitOfWork.ReceptionReservationDal.GetFirstOrDefault();
        }

        public IResult CancelReservation(ReceptionReservation receptionReservation)
        {
            receptionReservation.ReservationStatus = Entities.Enum.ReservationStatus.RezervasyonIptalEdildi;
            receptionReservation.Status = Core.Entities.Enum.Status.Deleted;

            var statusOfRoomId = receptionReservation.Room.StatusOfRooms.Where(x => x.StatusStartDate == receptionReservation.CheckInDate && x.StatusEndDate == receptionReservation.CheckOutDate).Select(x => x.ID).FirstOrDefault();
            try
            {
                unitOfWork.ReceptionReservationDal.Update(receptionReservation);
                unitOfWork.StatusOfRoomDal.RemoveForce(statusOfRoomId);

                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Rezervasyon başarıyla iptal edildi.";
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

        public IResult ReservationCreate(ReceptionReservation receptionReservation, StatusOfRoom statusOfRoom)
        {
            try
            {
                unitOfWork.ReceptionReservationDal.Create(receptionReservation);
                unitOfWork.StatusOfRoomDal.Create(statusOfRoom);
                //throw new InvalidOperationException("Logfile cannot be read-only");
                unitOfWork.SaveChange();
                result.ResultStatus = Core.Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Rezervasyon Oluşturma işlemi başarıyla gerçekleştirildi.";
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

        public async Task<List<ReceptionReservation>> NotPaidReservatins()
        {
            //Döngüden kurulup get default içinde sorgu tekrar denenecek o şekilde hata alıyor. Geçici çözüm.
            var date = DateTime.Now.Date;
            List<ReceptionReservation> receptionReservationList = new List<ReceptionReservation>();
            var receptionReservations = await this.GetDefault(x => x.Payment == false && x.ReservationStatus == ReservationStatus.RezervasyonAlindi);
            foreach (var item in receptionReservations)
            {
                if ((item.CheckInDate - date).TotalDays <= 2)
                {
                    receptionReservationList.Add(item);
                }
            }

            return receptionReservationList;
        }
    }
}
