using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using views.Models;
using views.NewFolder;

namespace views.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() {name = "The rise of jam"};
            ViewData["Movies"] = movie;

            var customers = new List<Customer>
            {
                new Customer { Name = "Johnson" },
                new Customer { Name = "Thandwelihle" },
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };


            return View(viewModel);
        }

       
    }
}
