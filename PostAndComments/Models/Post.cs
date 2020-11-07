using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAndComments.Models
{
    public class Post
    {
        public int postID { get; set; }
        public string postContent { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
