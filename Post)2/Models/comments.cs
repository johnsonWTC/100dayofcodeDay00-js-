using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_2.Models
{
    public class comments
    {
        public int commentsID { get; set; }
        public string comment { get; set; }

        public int postID { get; set; }
        public Post post { get; set; }
    }
}
