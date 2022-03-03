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
    public class HomePageMap : CoreMap<HomePage>, IEntityTypeConfiguration<HomePage>
    {
        public void Configure(EntityTypeBuilder<HomePage> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Subtitle).HasMaxLength(50);
            builder.Property(x => x.PictureUrl).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Paragraph1).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Paragraph2).HasMaxLength(500);
            builder.Property(x => x.Paragraph3).HasMaxLength(500);
            builder.Property(x => x.Paragraph4).HasMaxLength(500);
            builder.Property(x => x.Paragraph5).HasMaxLength(500);
        }
    }
}
