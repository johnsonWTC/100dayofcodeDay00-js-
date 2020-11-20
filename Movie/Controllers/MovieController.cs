using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            return View();
        }
    }
}
