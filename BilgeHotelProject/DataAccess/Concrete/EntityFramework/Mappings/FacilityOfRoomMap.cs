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
    public class FacilityOfRoomMap : CoreMap<FacilityOfRoom>, IEntityTypeConfiguration<FacilityOfRoom>
    {
        public void Configure(EntityTypeBuilder<FacilityOfRoom> builder)
        {
            CoreConfig(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.RoomFacilityID, x.RoomTypeID });
        }
    }
}
