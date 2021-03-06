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
    public class WorkScheduleMap : CoreMap<WorkSchedule>, IEntityTypeConfiguration<WorkSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkSchedule> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.Date).HasColumnType("date").IsRequired();
            builder.Property(x => x.TotalWorkTime).IsRequired();
            builder.Property(x => x.TimesWorked).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.ShiftName).IsRequired().HasMaxLength(50);
        }
    }
}
