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
    public class RoomFacilityMap : CoreMap<RoomFacility>, IEntityTypeConfiguration<RoomFacility>
    {
        public void Configure(EntityTypeBuilder<RoomFacility> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.FacilityName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
        }
    }
}
