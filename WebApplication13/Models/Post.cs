﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace WebApplication13.Models
{
    public class Post
    {
        public int postID { get; set; }
        public string postTitle { get; set; }
        public string postContent { get; set; }

        public int postLike { get; set;} 

        public int numberofviews { get; set; }  

        public List<comment> comments { get; set; }

        public int id { get; set; }

     








    }
}
