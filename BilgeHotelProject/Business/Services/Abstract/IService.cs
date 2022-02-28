using Core.Entities;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IService<T> where T : BaseEntity
    {
        IResult Create(T model);
        Task<List<T>> GetAll();
        Task<List<T>> GetActive();
        Task<T> GetById(int id);
        IResult Update(T model);
        IResult Delete(int id);
        IResult RemoveForce(int id);
        Task<bool> Any(Expression<Func<T, bool>> exp);
        Task<List<T>> GetDefault(Expression<Func<T, bool>> exp);
    }
}
