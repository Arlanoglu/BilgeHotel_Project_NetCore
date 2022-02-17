using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBaseDal<T> : EFEntityRepositoryBase<T, AppDbContext> where T: BaseEntity
    {
    }
}
