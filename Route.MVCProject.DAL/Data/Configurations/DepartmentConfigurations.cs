using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Route.MVCProject.DAL.Models;

namespace Route.MVCProject.DAL.Data.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           builder.Property(D => D.Id).UseIdentityColumn(10,10);

            builder.Property(D => D.Code)
                .HasColumnType(nameof(SqlDbType.VarChar))
                .HasMaxLength(50);            
            
            builder.Property(D => D.Name)
                .HasColumnType(nameof(SqlDbType.VarChar))
                .HasMaxLength(50);
        }
    }
}
