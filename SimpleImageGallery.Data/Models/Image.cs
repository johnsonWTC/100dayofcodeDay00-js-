using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleImageGallery.Data.Models
{
    public interface Image
    {
        IEnumerable<GalleryImage> GellAll();
        IEnumerable<GalleryImage> GetWithTag(string tag);
        GalleryImage GetGalleryById(int id);

    }
}
