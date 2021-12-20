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
    public class OrderConfigur : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

            builder.HasOne(o => o.Employee)
                .WithMany(e => e.Orders)
                .HasForeignKey(o => o.EmployeeId);

            builder.Property(o => o.OrderDate).IsRequired(false);
            builder.Property(o => o.RequiredDate).IsRequired(false);
            builder.Property(o => o.ShippedDate).IsRequired(false);
            builder.Property(o => o.ShipVia).IsRequired(false);
            builder.Property(o => o.Freight).IsRequired(false).HasColumnType("money");
            builder.Property(o => o.ShipName).IsRequired(false).HasColumnType("nvarchar(40)");
            builder.Property(o => o.ShipAddress).IsRequired(false).HasColumnType("nvarchar(60)");
            builder.Property(o => o.ShipCity).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(o => o.ShipRegion).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(o => o.ShipPostalCode).IsRequired(false).HasColumnType("nvarchar(10)");
            builder.Property(o => o.ShipCountry).IsRequired(false).HasColumnType("nvarchar(15)");

        }
    }
}
