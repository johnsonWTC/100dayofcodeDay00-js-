using APITest.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APITest.Models
{
    public class comment
    {
        public int commentID { get; set; }
        public string commentContent { get; set; }

        public int commentLikes { get; set; }

        public int commentViews { get; set; }

        public int postID { get; set; }
        public int id { get; set; }

       

        [JsonIgnore]
        public Post post { get; set; }

        public User User { get; set; }
    }
}
