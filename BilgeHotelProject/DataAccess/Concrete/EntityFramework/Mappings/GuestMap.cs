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
    public class GuestMap : BaseMap, IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IdentificationNumber).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Adress).HasMaxLength(200);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.IdCardFrontSideImage).HasMaxLength(300).IsRequired();
            builder.Property(x => x.IdCardBackSideImage).HasMaxLength(300).IsRequired();
        }
    }
}
