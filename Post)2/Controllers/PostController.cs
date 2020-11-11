using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index()
        {
            var postContext = _context.Posts.Include(c => c.comments);
            return View(await postContext.ToListAsync());
        }
    }
}
