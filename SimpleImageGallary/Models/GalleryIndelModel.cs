using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleImageGallary.Models
{
    public class GalleryIndelModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public int MyProperty { get; set; }
    }
}
