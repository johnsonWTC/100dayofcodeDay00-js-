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
            Customer customer = new Customer();
            customer.Name = "Johnson Dubula";

            Customer customer1 = new Customer();
            customer1.Name


            Show show = new Show();
            show.Name = "Mad Man";
            show.Id = 0;
            return View(show);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = "+ id);  
        }

        [Route("Movies/Released")]
        public ActionResult Released(int date)
        {
            return View();
        }
    }
}
