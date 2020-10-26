using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF06.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
    }
}
