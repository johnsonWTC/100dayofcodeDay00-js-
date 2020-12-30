﻿using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data.Models;
using System;

namespace SimpleImageGallery.Data
{
    public class SimpleImageGalleryDbContext : DbContext
    {
        public SimpleImageGalleryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public int MyProperty { get; set; }
    }
}
