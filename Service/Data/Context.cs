using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Data
{
    public class Context :DbContext
    {
        public SimpleImageGalleryDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<GalleryImage> GalleryImages { get; set; }
    public DbSet<ImageTag> ImageTags { get; set; }
}
{
    }
}
