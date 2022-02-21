using Core.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFShiftDal : EFBaseDal<Shift>, IShiftDal
    {
        public EFShiftDal(IResult result) : base(result)
        {
        }
    }
}
