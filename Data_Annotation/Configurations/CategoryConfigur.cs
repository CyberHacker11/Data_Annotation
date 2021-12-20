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
    public class CategoryConfigur : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(15)");
            builder.Property(c => c.Description).IsRequired(false).HasColumnType("ntext");
        }
    }
}
