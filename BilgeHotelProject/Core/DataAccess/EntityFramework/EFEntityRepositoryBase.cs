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
        private readonly TContext db;
        private readonly DbSet<TEntity> entity;
        public EFEntityRepositoryBase(TContext db)
        {
            this.db = db;
            entity = db.Set<TEntity>();
        }
        //IResult DI ı bu classtan kaldırılacak.
        public async Task<bool> Any(Expression<Func<TEntity, bool>> exp)
        {
            return await entity.AnyAsync(exp);
        }

        public void Create(TEntity model)
        {
            #region OldMetot
            //try
            //{
            //    entity.Add(model);
            //    db.SaveChanges();
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
            //    result.Message = "Oluşturma işlemi başarıyla gerçekleştirildi.";
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Error;
            //    result.Message = ex.Message;
            //    result.Exception = ex;
            //    return result;
            //}
            #endregion
            entity.Add(model);
        }

        public void Delete(int id)
        {
            #region OldMetot
            //try
            //{
            //    TEntity model = GetById(id);
            //    model.Status = Entities.Enum.Status.Deleted;
            //    db.SaveChanges();
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
            //    result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Error;
            //    result.Message = ex.Message;
            //    result.Exception = ex;
            //    return result;
            //}
            #endregion
            TEntity model = entity.Find(id);
            model.Status = Entities.Enum.Status.Deleted;
            Update(model);
        }

        public async Task<TEntity> GetById(int id)
        {
            return await entity.FindAsync(id);
        }

        public async Task<List<TEntity>> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            return await entity.Cast<TEntity>().Where(exp).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await entity.ToListAsync();
        }
        public async Task<List<TEntity>> GetActive()
        {
            return await entity.Where(x => x.Status == Entities.Enum.Status.Active).ToListAsync();
        }

        public void RemoveForce(int id)
        {
            #region OldMetot
            //try
            //{
            //    TEntity model = GetById(id);
            //    entity.Remove(model);
            //    db.SaveChanges();
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
            //    result.Message = "Silme işlemi başarıyla gerçekleştirildi.";
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
            //    result.Message = ex.Message;
            //    result.Exception = ex;
            //    return result;
            //}
            #endregion
            TEntity model = entity.Find(id);
            entity.Remove(model);

        }

        public void Update(TEntity model)
        {
            #region OldMetot
            //try
            //{
            //    TEntity entity = GetById(model.ID);
            //    db.Entry(entity).CurrentValues.SetValues(model);
            //    db.SaveChanges();
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
            //    result.Message = "Güncelleme işlemi başarıyla gerçekleştirildi.";
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    result.ResultStatus = Utilities.Results.Concrete.ResultStatus.Success;
            //    result.Message = ex.Message;
            //    result.Exception = ex;
            //    return result;
            //}
            #endregion
            TEntity entityModel = entity.Find(model.ID);
            db.Entry(entityModel).CurrentValues.SetValues(model);

        }
        
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> exp)
        {
            return entity.Where(exp);
        }

        public async Task<TEntity> GetFirstOrDefault()
        {
            return await entity.FirstOrDefaultAsync();
        }

        public void RemoveForce(TEntity model)
        {
            entity.Remove(model);
        }

        public void RemoveForceList(List<TEntity> modelList)
        {
            foreach (var item in modelList)
            {
                entity.Remove(item);
            }
        }
    }
}
