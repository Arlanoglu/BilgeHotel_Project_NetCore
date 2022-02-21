using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFUseOfExtraServiceDal : EFBaseDal<UseOfExtraService>, IUseOfExtraServiceDal
    {
        public EFUseOfExtraServiceDal(IResult result) : base(result)
        {
        }
    }
}
