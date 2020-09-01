using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using day100.Models;

namespace day100.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie();
            movie.MovieName = "Day 100";
            var client = new Clients();
            client.ClientName = "johnson";
            client.ClientName = "Thandwelihle";

            return View(movie);

        }
    }
}
