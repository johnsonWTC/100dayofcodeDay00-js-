using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleImageGallery.Data.Models
{
   public class GalleryImage
    {
        prop
        public  string Title { get; set; }
        public DateTime Created { get; set; }
        public string url { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
