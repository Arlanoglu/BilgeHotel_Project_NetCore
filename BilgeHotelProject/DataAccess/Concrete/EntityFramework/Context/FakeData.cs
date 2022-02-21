using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public static class FakeData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
                    new Department { ID = 1, DepartmentName = "Yardımcı Hizmetler" },
                    new Department { ID = 2, DepartmentName = "Bilgi İşlem" },
                    new Department { ID = 3, DepartmentName = "Mutfak" }
                );
        }
    }
}
