
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using APITest.Areas.Identity.Data;

namespace APITest.Models
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

        [JsonIgnore]
        public User User { get; set; }







    }
}
