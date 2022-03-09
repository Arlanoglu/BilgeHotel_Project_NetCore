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
    public class WebReservationMap : CoreMap<WebReservation>, IEntityTypeConfiguration<WebReservation>
    {
        public void Configure(EntityTypeBuilder<WebReservation> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.ReservationDate).HasColumnType("datetime");
            builder.Property(x => x.CheckInDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.CheckOutDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.NumberOfPeople).IsRequired();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.ReservationStatus).IsRequired();
            builder.Property(x => x.AppUserID).IsRequired();
        }
    }
}
