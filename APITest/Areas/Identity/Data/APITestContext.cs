using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITest.Areas.Identity.Data;
using APITest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APITest.Data
{
    public class APITestContext : IdentityDbContext<User>
    {
        public APITestContext()
       
        {
        }
        public APITestContext(DbContextOptions<APITestContext> options)
            : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<comment> comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
