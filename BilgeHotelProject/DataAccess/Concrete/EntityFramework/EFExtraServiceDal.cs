using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFExtraServiceDal : EFBaseDal<ExtraService>,IExtraServiceDal
    {
    }
}
