using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI5.Models
{
    public class MyDbContext : DbContext
    {
        
    
            public MyDbContext()
            {
            }

            public DbSet<User> Users { get; set; }

        }
    }
