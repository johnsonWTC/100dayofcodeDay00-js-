using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day100.Models;

namespace day100.ViewModel
{
    public class ClientMovieViewModel
    {
        public Movie movie { get; set; }
        public List<Clients> clients { get; set; }
    }
}
