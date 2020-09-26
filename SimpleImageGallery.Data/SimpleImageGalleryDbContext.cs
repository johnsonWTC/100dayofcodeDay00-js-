using Microsoft.EntityFrameworkCore;
using System;

namespace SimpleImageGallery.Data
{
    public class SimpleImageGalleryDbContext : DbContext
    {
        public SimpleImageGalleryDbContext(DbContextOptions options) : base(options)
        {

        }

        public int MyProperty { get; set; }
    }
}
