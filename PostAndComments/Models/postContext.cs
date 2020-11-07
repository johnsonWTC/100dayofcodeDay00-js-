using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAndComments.Models
{
    public class postContext : DbContext
    {
        public postContext(DbContextOptions<postContext> options): base(options)
        {
        }
    }
}

    
