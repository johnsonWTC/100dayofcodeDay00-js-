using API29.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API29.Data
{
    public class Context : DbContext 
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductOrder> ProductOrders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              optionsBuilder.UseSqlServer("Data Source=ASSET-10422\\SQLEXPRESS;Initial Catalog=New;Integrated Security=True");
           // optionsBuilder.UseSqlServer("server=.;database=dataTest;trusted_connection=true;");
           // "Data Source=ASSET-10422\\SQLEXPRESS;Initial Catalog=New;Integrated Security=True"
        }
    }
}
