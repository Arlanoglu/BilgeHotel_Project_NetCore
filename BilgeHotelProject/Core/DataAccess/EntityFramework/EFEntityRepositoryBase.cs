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
        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().Any(exp);
            }
        }

        public virtual string Create(TEntity model)
        {
            try
            {
                using (TContext db = new TContext())
                {
                    db.Set<TEntity>().Add(model);
                    db.SaveChanges();
                    return "Oluşturma işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                using (TContext db = new TContext())
                {
                    TEntity model = GetById(id);
                    model.Status = Entities.Enum.Status.Deleted;
                    db.SaveChanges();
                    return "Silme işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public TEntity GetById(int id)
        {
            using(TContext db = new TContext())
            {
                return db.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            using(TContext db = new TContext())
            {
                return db.Set<TEntity>().Cast<TEntity>().Where(exp).ToList();
            }
        }

        public List<TEntity> GetList()
        {
            using(TContext db = new TContext())
            {
                return db.Set<TEntity>().ToList();
            }
        }

        public string RemoveForce(int id)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    TEntity model = GetById(id);
                    db.Set<TEntity>().Remove(model);
                    db.SaveChanges();
                    return "Silme işlemi başarıyla gerçekleştirildi.";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Update(TEntity model)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    TEntity entity = GetById(model.ID);
                    db.Entry(entity).CurrentValues.SetValues(model);
                    db.SaveChanges();
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
