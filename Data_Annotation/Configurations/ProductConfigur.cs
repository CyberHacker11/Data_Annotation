using Data_Annotation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation.Configurations
{
    public class ProductConfigur : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasColumnType("nvarchar(40)");
            builder.Property(p => p.QuantityPerUnit).IsRequired(false).HasColumnType("nvarchar(20)");
            builder.Property(p => p.UnitPrice).IsRequired(false).HasColumnType("money");
            builder.Property(p => p.UnitsInStock).IsRequired(false).HasColumnType("smallint");
            builder.Property(p => p.UnitsOnOrder).IsRequired(false).HasColumnType("smallint");
            builder.Property(p => p.ReorderLevel).IsRequired(false).HasColumnType("smallint");
            builder.Property(p => p.Discontinued).IsRequired().HasColumnType("bit");
        }
    }
}
