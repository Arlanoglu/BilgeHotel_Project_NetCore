using Business.Services.Abstract;
using Core.Utilities.Results.Abstract;
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
        public Task<bool> Any(Expression<Func<HomePageSlide, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public IResult Create(HomePageSlide model)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HomePageSlide>> GetActive()
        {
            throw new NotImplementedException();
        }

        public Task<List<HomePageSlide>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<HomePageSlide> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HomePageSlide>> GetDefault(Expression<Func<HomePageSlide, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public IResult RemoveForce(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(HomePageSlide model)
        {
            throw new NotImplementedException();
        }
    }
}
