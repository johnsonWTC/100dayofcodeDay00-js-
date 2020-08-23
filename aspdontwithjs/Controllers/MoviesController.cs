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
            var movie = new Movie { Name = "Shrek", Id = 1 };
            ViewData["Movie"] = movie;
            return View();
        }

        public ActionResult Edit (int id)
        {

            return View();
        }
    }
}
