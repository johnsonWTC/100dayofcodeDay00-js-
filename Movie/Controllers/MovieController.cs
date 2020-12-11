﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.ViewModels;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            Customer customer = new Customer();
            customer.Name = "Johnson Dubula";

            Customer customer1 = new Customer();
            customer1.Name = "Thandwelihle Dubula";

            List<Customer> customers = new List<Customer>();
            customers.Add(customer);
            customers.Add(customer1);

            RandomMovieVieModel randomMovieVieModel = new RandomMovieVieModel();
            randomMovieVieModel.Customers = customers;

            Show show = new Show();
            show.Name = "Mad Man";
            show.Id = 0;
            randomMovieVieModel.Movie = show;





            return View(randomMovieVieModel );

          





        }

        public ActionResult Edit(int id)
        {
            return Content("id = "+ id);  
        }

    
        public ActionResult Details(int id)
        {


            return View();
        }
    }
}
