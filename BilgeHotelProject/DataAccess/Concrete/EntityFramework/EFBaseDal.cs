using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Utilities.Results.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBaseDal<T> : EFEntityRepositoryBase<T, AppDbContext> where T: BaseEntity
    {
        public EFBaseDal(IResult result) : base(result)
        {
        }
    }
}
