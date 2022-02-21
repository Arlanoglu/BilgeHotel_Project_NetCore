using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFServicePackDal : EFBaseDal<ServicePack>, IServicePackDal
    {
        public EFServicePackDal(IResult result) : base(result)
        {
        }
    }
}
