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
    public class EmployeeMap : CoreMap<Employee>, IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            CoreConfig(builder);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(20);            
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.StartDateOfWork).IsRequired().HasColumnType("date");
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.IdentificationNumber).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(x => x.LeavingWorkDate).HasColumnType("date");
            builder.Property(x => x.ReasonForLeaving).HasMaxLength(200);
            builder.Property(x => x.EmployeeStatus).IsRequired();        

        }
    }
}
