using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace API01.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public DbSet<User> Users{ get; set; }
     
    }
}



