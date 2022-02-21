using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSalaryDal : EFBaseDal<Salary>, ISalaryDal
    {
        public EFSalaryDal(IResult result) : base(result)
        {
        }
    }
}
