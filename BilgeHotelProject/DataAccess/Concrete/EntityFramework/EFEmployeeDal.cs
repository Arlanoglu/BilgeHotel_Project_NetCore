using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEmployeeDal : EFBaseDal<Employee>,IEmployeeDal
    {
    }
}
