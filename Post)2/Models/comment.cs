using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Post_2.Models
{
    public class comment
    {
        public int commentID { get; set; }
        public string commentContent { get; set; }

        public int commentLikes { get; set; }

        public int postID { get; set; }

        [JsonIgnore]
        public Post post { get; set; }
    }
}
