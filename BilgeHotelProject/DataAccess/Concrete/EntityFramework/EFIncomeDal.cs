using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFIncomeDal : EFBaseDal<Income>, IIncomeDal
    {
        public EFIncomeDal(IResult result) : base(result)
        {
        }
    }
}
