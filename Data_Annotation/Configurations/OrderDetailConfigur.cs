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
    public class OrderDetailConfigur : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Ignore(od => od.Id);
            builder.HasKey(od => new { od.ProductId, od.OrderId });

            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            builder.HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);

            builder.Property(od => od.UnitPrice).IsRequired().HasColumnType("money");
            builder.Property(od => od.Quantity).IsRequired().HasColumnType("smallint");
            builder.Property(od => od.Discount).IsRequired().HasColumnType("real");
        }
    }
}
