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
    public class UseOfExtraServiceMap : BaseMap, IEntityTypeConfiguration<UseOfExtraService>
    {
        public void Configure(EntityTypeBuilder<UseOfExtraService> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => x.ExtraServiceID);
            builder.HasKey(x => x.RegistrationID);
        }
    }
}
