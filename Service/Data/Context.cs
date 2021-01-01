using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
   
}
{
    }
}
