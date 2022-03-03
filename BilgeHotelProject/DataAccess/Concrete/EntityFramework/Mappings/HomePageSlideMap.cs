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
    public class HomePageSlideMap : CoreMap<HomePageSlide>, IEntityTypeConfiguration<HomePageSlide>
    {
        public void Configure(EntityTypeBuilder<HomePageSlide> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.PictureName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.PictureUrl).HasMaxLength(200).IsRequired();
        }
    }
}
