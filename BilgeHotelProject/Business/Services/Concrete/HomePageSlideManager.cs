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
    public class HomePageSlideManager : IHomePageSlideService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IResult result;

        public HomePageSlideManager(IUnitOfWork unitOfWork, IResult result)
        {
            this.unitOfWork = unitOfWork;
            this.result = result;
        }

        public async Task<bool> Any(Expression<Func<HomePageSlide, bool>> exp)
        {
            return await unitOfWork.HomePageSlideDal.Any(exp);
        }

        public IResult Create(HomePageSlide model)
        {
            try
            {
                unitOfWork.HomePageSlideDal.Create(model);
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
                unitOfWork.HomePageSlideDal.Delete(id);
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

        public async Task<List<HomePageSlide>> GetActive()
        {
            return await unitOfWork.HomePageSlideDal.GetActive();
        }

        public async Task<List<HomePageSlide>> GetAll()
        {
            return await unitOfWork.HomePageSlideDal.GetAll();
        }

        public async Task<HomePageSlide> GetById(int id)
        {
            return await unitOfWork.HomePageSlideDal.GetById(id);
        }

        public async Task<List<HomePageSlide>> GetDefault(Expression<Func<HomePageSlide, bool>> exp)
        {
            return await unitOfWork.HomePageSlideDal.GetDefault(exp);
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                unitOfWork.HomePageSlideDal.RemoveForce(id);
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

        public IResult Update(HomePageSlide model)
        {
            try
            {
                unitOfWork.HomePageSlideDal.Update(model);
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
        public async Task<HomePageSlide> GetFirstOrDefault()
        {
            return await unitOfWork.HomePageSlideDal.GetFirstOrDefault();
        }
    }
}
