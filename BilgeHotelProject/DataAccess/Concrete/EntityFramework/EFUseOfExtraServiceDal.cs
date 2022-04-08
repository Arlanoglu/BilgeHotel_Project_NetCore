using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFUseOfExtraServiceDal : EFBaseDal<UseOfExtraService>, IUseOfExtraServiceDal
    {
        private readonly AppDbContext db;

        public EFUseOfExtraServiceDal(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public void UpdateSelf(UseOfExtraService model)
        {
            var entity = db.UseOfExtraServices.Where(x => x.RegistrationID == model.RegistrationID && x.ExtraServiceID == model.ExtraServiceID).FirstOrDefault();
            db.Entry(entity).CurrentValues.SetValues(model);
        }
    }
}
