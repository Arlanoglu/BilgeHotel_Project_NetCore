using Core.Entities;
using Core.Utilities.Results.Abstract;
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
        private readonly IResult result;
        private readonly TContext db;
        private readonly DbSet<TEntity> entity;
        public EFEntityRepositoryBase(IResult result, TContext db)
        {
            this.result = result;
            this.db = db;
            entity = db.Set<TEntity>();
        }

        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            return entity.Any(exp);
        }

        public IResult Create(TEntity model)
        {
            try
            {
                entity.Add(model);
                db.SaveChanges();
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Oluşturma işlemi başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Error;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

        public IResult Delete(int id)
        {
            try
            {
                TEntity model = GetById(id);
                model.Status = Entities.Enum.Status.Deleted;
                db.SaveChanges();
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Error;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

        public TEntity GetById(int id)
        {
            return entity.Find(id);
        }

        public List<TEntity> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            return entity.Cast<TEntity>().Where(exp).ToList();
        }

        public List<TEntity> GetAll()
        {
            return entity.ToList();
        }
        public List<TEntity> GetActive()
        {
            return entity.Where(x => x.Status == Entities.Enum.Status.Active).ToList();
        }

        public IResult RemoveForce(int id)
        {
            try
            {
                TEntity model = GetById(id);
                entity.Remove(model);
                db.SaveChanges();
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

        public IResult Update(TEntity model)
        {
            try
            {
                TEntity entity = GetById(model.ID);
                db.Entry(entity).CurrentValues.SetValues(model);
                db.SaveChanges();
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = "Güncelleme işlemi başarıyla gerçekleştirildi.";
                return result;
            }
            catch (Exception ex)
            {
                result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
                result.Message = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

    }
}
