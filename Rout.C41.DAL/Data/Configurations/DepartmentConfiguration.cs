using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rout.C41.DAL.Model;

namespace Rout.C41.DAL.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10, 10);
            builder.Property(n => n.Name ).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Code).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        }
    }
}
