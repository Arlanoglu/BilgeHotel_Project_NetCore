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
    public class EmployeeShiftMap : CoreMap<EmployeeShift>, IEntityTypeConfiguration<EmployeeShift>
    {
        public void Configure(EntityTypeBuilder<EmployeeShift> builder)
        {
            CoreConfig(builder);
            //builder.Ignore(x => x.ID);
            //builder.HasKey(x => new { x.EmployeeID, x.ShiftID });
        }
    }
}
