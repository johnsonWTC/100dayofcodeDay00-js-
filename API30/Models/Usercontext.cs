using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API30.Models
{
    public class Usercontext : DbContext
    {
        public Usercontext(DbContextOptions<Usercontext> options) :base(options)
        {
        }


        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ASSET-10422\\SQLEXPRESS;Initial Catalog=API30;Integrated Security=True");
            // optionsBuilder.UseSqlServer("server=.;database=dataTest;trusted_connection=true;");
            // "Data Source=ASSET-10422\\SQLEXPRESS;Initial Catalog=New;Integrated Security=True"
        }

    }
}
