using Microsoft.EntityFrameworkCore;
using Entity00.Models;

namespace Entity00.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=blogging.db");



    }
}
