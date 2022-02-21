using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRegistrationDal : EFBaseDal<Registration>, IRegistrationDal
    {
        public EFRegistrationDal(IResult result) : base(result)
        {
        }
    }
}
