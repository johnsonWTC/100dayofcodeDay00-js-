using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoApp.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Tittle { get; set; }

        public DateTime DateCreated { get; set; }

        public int Likes { get; set; }
    }
}
