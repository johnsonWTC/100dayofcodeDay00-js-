using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post_2.Models;

namespace Post_2.Controllers
{
    public class PoastController : Controller
    {
       
        public IActionResult Index()
        {
             public List<Post> Posts { get; set; }
             public List<comment> comments { get; set; }

            return View();
        }
    }
}
