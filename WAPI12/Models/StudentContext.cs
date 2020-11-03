using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAPI12.Models
{
    public class StudentContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Faculty> faculties { get; set; }
    }
}
