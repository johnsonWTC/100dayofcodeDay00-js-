using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF03.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FE03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // optionsBuilder.UseSqlServer("server=.;database=dataTest;trusted_connection=true;");
            // "Data Source=ASSET-10422\\SQLEXPRESS;Initial Catalog=New;Integrated Security=True"
        }
    }
}
