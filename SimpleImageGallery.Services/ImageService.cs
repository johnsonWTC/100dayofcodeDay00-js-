using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleImageGallery.Services
{
    public class ImageService : Image
    {
        private readonly SimpleImageGalleryDbContext _context;

        public ImageService(SimpleImageGalleryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GalleryImage> GetAll()
        {
           return _context.GalleryImages.Include(e => e.Tags);
        }

        public GalleryImage GetGalleryById(int id)
        {
            return _context.GalleryImages.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Discription == tag));
        }
    }
}
