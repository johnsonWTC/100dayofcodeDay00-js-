using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Post_2.Models;

namespace Post_2.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Post_2User class
    public class Post_2User : IdentityUser
    {
        public List<Post> posts { get; set; }

    }
}
