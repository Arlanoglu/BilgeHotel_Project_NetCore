using Core.DataAccess.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class PictureMap : CoreMap<Picture>, IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.PictureName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.PictureUrl).HasMaxLength(200).IsRequired();
        }
    }
}
