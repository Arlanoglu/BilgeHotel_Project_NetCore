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
                    new Department { DepartmentName = "Yardımcı Hizmetler" },
                    new Department { DepartmentName = "Bilgi İşlem" },
                    new Department { DepartmentName = "Mutfak" }
                );
        }
    }
}
