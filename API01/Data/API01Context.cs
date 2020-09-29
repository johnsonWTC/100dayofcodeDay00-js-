using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API01.Models;

namespace API01.Data
{
    public class API01Context : DbContext
    {
        public API01Context (DbContextOptions<API01Context> options)
            : base(options)
        {
        }

        public DbSet<API01.Models.User> User { get; set; }
    }
}
