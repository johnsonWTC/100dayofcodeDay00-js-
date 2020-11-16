using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Post_2.Areas.Identity.Data;
using Post_2.Models;

namespace Post_2.Data
{
    public class Post_2Context : IdentityDbContext<Post_2User>
    {
        public Post_2Context(DbContextOptions<Post_2Context> options)
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
