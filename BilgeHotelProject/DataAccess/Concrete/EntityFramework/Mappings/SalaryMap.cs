using Core.DataAccess.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class SalaryMap : CoreMap<Salary>, IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.MounthlySalary).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.EmployeeID).IsRequired();
        }
    }
}
