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
    public class ReceptionReservationMap : CoreMap<ReceptionReservation>, IEntityTypeConfiguration<ReceptionReservation>
    {
        public void Configure(EntityTypeBuilder<ReceptionReservation> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.NumberOfPeople).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.ReservationStatus).IsRequired();
        }
    }
}
