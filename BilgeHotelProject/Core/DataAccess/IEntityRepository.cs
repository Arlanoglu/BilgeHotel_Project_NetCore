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
        IResult Create(T model);
        List<T> GetAll();
        List<T> GetActive();
        T GetById(int id);
        IResult Update(T model);
        IResult Delete(int id);
        IResult RemoveForce(int id);
        bool Any(Expression<Func<T, bool>> exp);
        List<T> GetDefault(Expression<Func<T, bool>> exp);
        
    }
}
