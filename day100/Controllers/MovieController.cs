using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace day100.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            return View();
        }
    }
}
