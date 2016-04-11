using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC2.Models;

namespace MVC2.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }

    }
}