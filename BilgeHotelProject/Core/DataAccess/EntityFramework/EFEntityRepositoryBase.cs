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
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : BaseEntity where TContext : DbContext, new()
    {
        public async Task<bool> Any(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext db = new TContext())
            {
                return await db.Set<TEntity>().AnyAsync(exp);
            }
        }

        public Task<string> Create(TEntity model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Delete(int id)
        {
            using (TContext db = new TContext())
            {
                try
                {
                    //Todo: delete işleminde sadece statu değişecek. ForceRemoveda silme işlemi yapılacak.
                    return "Veri Silindi.";
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetList(TEntity model)
        {
            throw new NotImplementedException();
        }

        public Task<string> Update(TEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
