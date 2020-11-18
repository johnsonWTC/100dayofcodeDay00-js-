using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_2.Models
{
    public class PostsViewModel
    {
        public List<Post> posts { get; set; }
        public List<comment> comments { get; set; } 
    }
}
