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
    public class IncomeMap : CoreMap<Income>, IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.IncomeDate).HasColumnType("date");
        }
    }
}
