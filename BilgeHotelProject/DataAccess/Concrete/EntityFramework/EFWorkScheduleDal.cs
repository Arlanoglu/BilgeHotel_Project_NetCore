using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFWorkScheduleDal : EFBaseDal<WorkSchedule>, IWorkScheduleDal 
    {
    }
}
