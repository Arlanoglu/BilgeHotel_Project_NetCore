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
    public class RoomPictureMap : BaseMap, IEntityTypeConfiguration<RoomPicture>
    {
        public void Configure(EntityTypeBuilder<RoomPicture> builder)
        {
            builder.Property(x => x.Picture).HasMaxLength(150).IsRequired();
            builder.Property(x => x.RoomTypeID).IsRequired();
        }
    }
}
