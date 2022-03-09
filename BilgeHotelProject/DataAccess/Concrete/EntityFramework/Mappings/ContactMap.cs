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
    public class ContactMap : CoreMap<Contact>, IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.Adress).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Phone1).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Phone2).HasMaxLength(11);
            builder.Property(x => x.Fax).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Facebook).HasMaxLength(200);
            builder.Property(x => x.Instagram).HasMaxLength(200);
            builder.Property(x => x.Twitter).HasMaxLength(200);
        }
    }
}
