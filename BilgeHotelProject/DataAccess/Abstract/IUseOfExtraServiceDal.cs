using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUseOfExtraServiceDal : IEntityRepository<UseOfExtraService>
    {
        public void UpdateSelf(UseOfExtraService model);
    }
}
