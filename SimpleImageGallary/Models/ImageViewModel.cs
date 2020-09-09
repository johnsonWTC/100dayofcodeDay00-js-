using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleImageGallary.Models
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string url { get; set; }
        public virtual IEnumerable<string> Tags { get; set; }
    }
}
