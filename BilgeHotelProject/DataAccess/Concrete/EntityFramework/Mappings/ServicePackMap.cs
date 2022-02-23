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
    public class ServicePackMap : CoreMap<ServicePack>, IEntityTypeConfiguration<ServicePack>
    {
        public void Configure(EntityTypeBuilder<ServicePack> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.PackName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PackPrice).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
        }
    }
}
