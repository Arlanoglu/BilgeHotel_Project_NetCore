using Core.Entities;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : BaseEntity
    {
        void Create(T model);
        Task<List<T>> GetAll();
        Task<List<T>> GetActive();
        Task<T> GetById(int id);
        void Update(T model);
        void Delete(int id);
        void RemoveForce(int id);
        Task<bool> Any(Expression<Func<T, bool>> exp);
        Task<List<T>> GetDefault(Expression<Func<T, bool>> exp);
        IQueryable<T> Where(Expression<Func<T, bool>> exp);
        Task<T> GetFirstOrDefault();

    }
}
