using Data_Annotation.Configurations;
using Data_Annotation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderDetail>? OrderDetails { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CYBER-HACKER\\SQLEXPRESS;Initial Catalog=MyNorthwind;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfigur());
            modelBuilder.ApplyConfiguration(new CustomerConfigur());
            modelBuilder.ApplyConfiguration(new EmployeeConfigur());
            modelBuilder.ApplyConfiguration(new OrderConfigur());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigur());
            modelBuilder.ApplyConfiguration(new ProductConfigur());

            base.OnModelCreating(modelBuilder);
        }
    }
}
