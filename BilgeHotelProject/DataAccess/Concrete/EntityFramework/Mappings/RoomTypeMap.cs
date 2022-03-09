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
    public class RoomTypeMap : CoreMap<RoomType>, IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.RoomTypeName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.NumberOfPeople).IsRequired();
            builder.Property(x => x.NumberOfBed).IsRequired();
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
