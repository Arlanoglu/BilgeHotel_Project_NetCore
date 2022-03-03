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
    public class SettingMap : CoreMap<Setting>, IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.SmtpHost).HasMaxLength(50).IsRequired();
            builder.Property(x => x.SmtpPort).HasMaxLength(10).IsRequired();
            builder.Property(x => x.SmtpEmail).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SmtpPassword).HasMaxLength(50).IsRequired();
        }
    }
}
