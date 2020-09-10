﻿using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;
using System;
using System.Collections.Generic;

namespace SimpleImageGallery.Services
{
    public class ImaageService : Image
    {
        private readonly SimpleImageGalleryDbContext _context;

        public ImaageService(SimpleImageGalleryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GalleryImage> GellAll()
        {
           return _context.GalleryImages.Include(e => e.Tags);
        }

        public GalleryImage GetGalleryById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            throw new NotImplementedException();
        }
    }
}
