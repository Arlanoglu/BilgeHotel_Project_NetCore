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

        public  async Task<string> Create(TEntity model)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    await db.Set<TEntity>().AddAsync(model);
                    await db.SaveChangesAsync();
                    return "Oluşturma işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> Delete(int id)
        {
            try
            {
                using (TContext db = new TContext())
                {
                    TEntity model = await GetById(id);
                    model.Status = Entities.Enum.Status.Deleted;
                    await db.SaveChangesAsync();
                    return "Silme işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using(TContext db = new TContext())
            {
                return await db.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<List<TEntity>> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            using(TContext db = new TContext())
            {
                return await db.Set<TEntity>().Cast<TEntity>().Where(exp).ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetList()
        {
            using(TContext db = new TContext())
            {
                return await db.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<string> RemoveForce(int id)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    TEntity model = await GetById(id);
                    db.Set<TEntity>().Remove(model);
                    await db.SaveChangesAsync();
                    return "Silme işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> Update(TEntity model)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    TEntity entity = await GetById(model.ID);
                    db.Entry(entity).CurrentValues.SetValues(model);
                    await db.SaveChangesAsync();
                    return "Güncelleme işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
