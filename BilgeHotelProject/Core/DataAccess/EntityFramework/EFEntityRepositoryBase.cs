using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : BaseEntity where TContext : DbContext
    {
        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public string Create(TEntity model)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(TEntity model)
        {
            throw new NotImplementedException();
        }

        public string Update(TEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
