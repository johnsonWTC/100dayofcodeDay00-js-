using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Showie.Models;

namespace Showie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Movie> movies { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<MemberShipType> memberShipTypes { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
