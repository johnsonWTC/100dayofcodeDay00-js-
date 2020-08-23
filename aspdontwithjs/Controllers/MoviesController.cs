using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspdontwithjs.Models;

namespace aspdontwithjs.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            return View();
        }
    }
}
