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
    public class HotelServiceMap : CoreMap<HotelService>, IEntityTypeConfiguration<HotelService>
    {
        public void Configure(EntityTypeBuilder<HotelService> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.IconPicture).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ServiceName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
        }
    }
}
