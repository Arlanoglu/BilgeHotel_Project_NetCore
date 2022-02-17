using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFDepartmentDal : EFBaseDal<Department>,IDepartmentDal
    {
    }
}
