using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post_2.Models;

namespace Post_2.Controllers
{
    public class PostController : Controller
    {
        private readonly PostContext _context;

        public PostController(PostContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           


            
            return View(_context.Posts.ToList());

        }
    }
}
