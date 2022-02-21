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
    public class FacilityOfRoomMap : BaseMap, IEntityTypeConfiguration<FacilityOfRoom>
    {
        public void Configure(EntityTypeBuilder<FacilityOfRoom> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => x.RoomFacilityID);
            builder.HasKey(x => x.RoomTypeID);
        }
    }
}
