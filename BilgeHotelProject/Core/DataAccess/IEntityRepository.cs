using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : BaseEntity
    {
        string Create { get; set; }
        List<T> GetList { get; set; }
    }
}
