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
        [Route]
        public IActionResult Random()
        {
            Show show = new Show();
            show.Name = "Mad Man";
            show.Id = 0;
            return View(show);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = "+ id);  
        }
    }
}
