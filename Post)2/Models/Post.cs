﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_2.Models
{
    public class Post
    {
        public int postID { get; set; }
        public string postContent { get; set; }

        public comments comments { get; set; }
    }
}
