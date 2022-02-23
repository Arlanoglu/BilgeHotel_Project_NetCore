using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Mappings
{
    public abstract class CoreMap<T> where T : BaseEntity
    {
        public void CoreConfig(EntityTypeBuilder<T> builder)
        {
            
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Status).HasDefaultValue(Core.Entities.Enum.Status.Active).IsRequired();

            builder.Property(x => x.ModifiedBy).HasMaxLength(20);
            builder.Property(x => x.CreatedBy).HasMaxLength(20);
            builder.Property(x => x.CreatedIP).HasMaxLength(20);
            builder.Property(x => x.ModifiedIP).HasMaxLength(20);
            builder.Property(x => x.CreatedComputerName).HasMaxLength(50);
            builder.Property(x => x.ModifiedComputerName).HasMaxLength(50);
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");
            builder.Property(x => x.ModifiedDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedUserName).HasMaxLength(50);
            builder.Property(x => x.ModifiedUsername).HasMaxLength(50);
        }
    }
}
