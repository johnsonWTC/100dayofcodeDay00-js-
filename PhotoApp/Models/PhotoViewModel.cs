using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoApp.Models
{
    public class PhotoViewModel
    {
        public string Tittle { get; set; }

        public DateTime DateCreated { get; set; }

        public int Likes { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        public string ProfilePicture { get; set; }
    }
}
