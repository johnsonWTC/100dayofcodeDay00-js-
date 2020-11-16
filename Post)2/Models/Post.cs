using Post_2.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Post_2.Models
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
        public Post_2User Post_2User { get; set; }





    }
}
