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
    public class WebReservationManager : IWebReservationService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public WebReservationManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }
        public async Task<bool> Any(Expression<Func<WebReservation, bool>> exp)
        {
            return await unitOfWork.WebReservationDal.Any(exp);
        }

        public IResult Create(WebReservation model)
        {
            try
            {
                unitOfWork.WebReservationDal.Create(model);
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
                unitOfWork.WebReservationDal.Delete(id);
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

        public async Task<List<WebReservation>> GetActive()
        {
            return await unitOfWork.WebReservationDal.GetActive();
        }

        public async Task<List<WebReservation>> GetAll()
        {
            return await unitOfWork.WebReservationDal.GetAll();
        }

        public async Task<WebReservation> GetById(int id)
        {
            return await unitOfWork.WebReservationDal.GetById(id);
        }

        public async Task<List<WebReservation>> GetDefault(Expression<Func<WebReservation, bool>> exp)
        {
            return await unitOfWork.WebReservationDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.WebReservationDal.RemoveForce(id);
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

        public IResult Update(WebReservation model)
        {
            try
            {
                unitOfWork.WebReservationDal.Update(model);
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
        public async Task<WebReservation> GetFirstOrDefault()
        {
            return await unitOfWork.WebReservationDal.GetFirstOrDefault();
        }

        public decimal DiscountPrice(decimal reservationPrice, DateTime checkInDate, DateTime reservationDate, string servicePackName)
        {
            var resultDays = (checkInDate.Date - reservationDate.Date).TotalDays;
            if (resultDays > 30 && resultDays <= 90 && servicePackName == "Her Şey Dahil")
            {
                reservationPrice = reservationPrice - (reservationPrice * 18 / 100);
            }
            else if (resultDays > 30 && resultDays <= 90 && servicePackName == "Tam Pansiyon")
            {
                reservationPrice = reservationPrice - (reservationPrice * 16 / 100);
            }
            else if (resultDays > 90)
            {
                reservationPrice = reservationPrice - (reservationPrice * 23 / 100);
            }

            return reservationPrice;
        }

        public IResult ReservationCreate(WebReservation webReservation, StatusOfRoom statusOfRoom)
        {
            try
            {
                unitOfWork.WebReservationDal.Create(webReservation);
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

        public IResult CancelReservation(WebReservation webReservation)
        {
            webReservation.ReservationStatus = Entities.Enum.ReservationStatus.RezervasyonIptalEdildi;
            webReservation.Status = Core.Entities.Enum.Status.Modified;

            var statusOfRoomId = webReservation.Room.StatusOfRooms.Where(x => x.StatusStartDate == webReservation.CheckInDate && x.StatusEndDate == webReservation.CheckOutDate).Select(x=>x.ID).FirstOrDefault();
            try
            {
                unitOfWork.WebReservationDal.Update(webReservation);
                unitOfWork.StatusOfRoomDal.Delete(statusOfRoomId);

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
    }
}
