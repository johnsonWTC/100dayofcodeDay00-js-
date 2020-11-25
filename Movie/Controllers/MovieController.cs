using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            Show show = new Show();
            show.Name = "";
            return View();
        }
    }
}
