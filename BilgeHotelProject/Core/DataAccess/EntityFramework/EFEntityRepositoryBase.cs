using Core.Entities;
using Core.Results.Abstract;
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
        private readonly IResult result;
        public EFEntityRepositoryBase(IResult result)
        {
            this.result = result;
        }

        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().Any(exp);
            }
        }

        public IResult Create(TEntity model)
        {
            try
            {
                using (TContext db = new TContext())
                {
                    db.Set<TEntity>().Add(model);
                    db.SaveChanges();
                    result.ResultStatus = Results.Concrete.ResultStatus.Success;
                    result.Message = "Oluşturma işlemi başarıyla gerçekleştirildi.";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.ResultStatus = Results.Concrete.ResultStatus.Error;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

        public IResult Delete(int id)
        {
            try
            {
                using (TContext db = new TContext())
                {
                    TEntity model = GetById(id);
                    model.Status = Entities.Enum.Status.Deleted;
                    db.SaveChanges();
                    result.ResultStatus = Results.Concrete.ResultStatus.Success;
                    result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.ResultStatus = Results.Concrete.ResultStatus.Error;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
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

        public List<TEntity> GetAll()
        {
            using(TContext db = new TContext())
            {
                return db.Set<TEntity>().ToList();
            }
        }
        public List<TEntity> GetActive()
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().Where(x => x.Status == Entities.Enum.Status.Active).ToList();
            }
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    TEntity model = GetById(id);
                    db.Set<TEntity>().Remove(model);
                    db.SaveChanges();
                    result.ResultStatus = Results.Concrete.ResultStatus.Success;
                    result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.ResultStatus = Results.Concrete.ResultStatus.Success;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

        public IResult Update(TEntity model)
        {
            try
            {
                using(TContext db = new TContext())
                {
                    TEntity entity = GetById(model.ID);
                    db.Entry(entity).CurrentValues.SetValues(model);
                    db.SaveChanges();
                    result.ResultStatus = Results.Concrete.ResultStatus.Success;
                    result.Message = "Güncelleme işlemi başarıyla gerçekleştirildi.";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.ResultStatus = Results.Concrete.ResultStatus.Success;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

    }
}
