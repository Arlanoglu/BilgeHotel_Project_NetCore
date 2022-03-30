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
    public class RegistrationMap : CoreMap<Registration>, IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.CheckInDate).HasColumnType("date");
            builder.Property(x => x.CheckOutDate).HasColumnType("date");
            builder.Property(x => x.NumberOfPeople).IsRequired();
            builder.Property(x => x.RegistrationType).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.CheckInTime).IsRequired().HasDefaultValue(TimeSpan.FromHours(14));
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(100);

        }
    }
}
