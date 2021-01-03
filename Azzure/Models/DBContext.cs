using Azzure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azzure.Models
{
    public class DBContext : DbContext
    {
    public DBContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Image> Images { get; set; }


    }

}

