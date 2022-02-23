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
    public class StatusOfRoomMap : CoreMap<StatusOfRoom>, IEntityTypeConfiguration<StatusOfRoom>
    {
        public void Configure(EntityTypeBuilder<StatusOfRoom> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.StatusStartDate).IsRequired().HasColumnType("date");
            builder.Property(x => x.StatusEndDate).IsRequired().HasColumnType("date");
            builder.Property(x => x.RoomStatus).IsRequired();
            builder.Property(x => x.RoomID).IsRequired();
        }
    }
}
