using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF10.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}
