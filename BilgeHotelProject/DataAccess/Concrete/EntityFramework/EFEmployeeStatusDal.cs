using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEmployeeStatusDal : EFBaseDal<EmployeeStatus>,IEmployeeStatusDal
    {
    }
}
