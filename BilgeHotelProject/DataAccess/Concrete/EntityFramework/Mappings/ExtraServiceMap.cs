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
    public class ExtraServiceMap : CoreMap<ExtraService>, IEntityTypeConfiguration<ExtraService>
    {
        public void Configure(EntityTypeBuilder<ExtraService> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.ServiceName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
