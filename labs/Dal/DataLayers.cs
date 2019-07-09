using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using labs.Models;

namespace labs.Dal
{

    public class DataLayers:DbContext
    {

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().ToTable("tblProduct");
        modelBuilder.Entity<User>().ToTable("tblUser");
        modelBuilder.Entity<Employee>().ToTable("tblEmployees");
        modelBuilder.Entity<Supplier>().ToTable("tblSupplier");

        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}