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
    public class GuestRegistrationMap : CoreMap<GuestRegistration>, IEntityTypeConfiguration<GuestRegistration>
    {
        public void Configure(EntityTypeBuilder<GuestRegistration> builder)
        {
            CoreConfig(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.RegistrationID, x.GuestID });
        }
    }
}
