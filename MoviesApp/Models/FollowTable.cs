using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class FollowTable
    {
        public int Id { get; set; }

        public int FollowerID { get; set; }

        public int FollowedID { get; set; }


    }
}
