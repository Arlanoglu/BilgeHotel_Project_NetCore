using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFDepartmentDal : EFBaseDal<Department>, IDepartmentDal
    {
        public EFDepartmentDal(IResult result) : base(result)
        {
        }
    }
}
