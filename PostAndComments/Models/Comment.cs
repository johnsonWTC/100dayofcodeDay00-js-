﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAndComments.Models
{
    public class Comment
    {
        public int commentID { get; set; }
        public string comment { get; set; }
        public Post post { get; set; }
        public int postID { get; set; }
    }
}
