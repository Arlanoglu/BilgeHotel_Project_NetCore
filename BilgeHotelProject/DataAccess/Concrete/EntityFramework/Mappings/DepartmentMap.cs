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
    public class DepartmentMap : CoreMap<Department>, IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.DepartmentName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
        }
    }
}
