using Core.Entities;
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
        Task<string> Create(T model);
        Task<List<T>> GetList();
        Task<T> GetById(int id);
        Task<string> Update(T model);
        Task<string> Delete(int id);
        Task<string> RemoveForce(int id);
        Task<bool> Any(Expression<Func<T, bool>> exp);
        Task<List<T>> GetDefault(Expression<Func<T, bool>> exp);
        
    }
}
