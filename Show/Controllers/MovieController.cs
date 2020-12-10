using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Show.Data;
using Show.Models;
using Show.ViewModel;

namespace Show.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext applicationDBContect;

        public MovieController()
        {
            applicationDBContect = new ApplicationDbContext();
        }
       
        // GET: MovieController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieController/Details/5
        public ActionResult Random(int id)
        {
            var movie = new Movie();
            movie.Name = "Age Of Altron";

            var movieTwo = new Movie();
            movieTwo.Name = "Winter Soldier";



            var customer = new Customer();
            customer.Name = "Johnson";


            var customerTwo = new Customer();
            customerTwo.Name = "Thandwelihle";


            List<Customer> customers = new List<Customer>();
            customers.Add(customer);
            customers.Add(customerTwo);





            ShowViewModel viewModel = new ShowViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;

             return View(viewModel);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public void AddFollower()
        {
            
            int FollowedID = 4;
            int FollowerID = 5;


        }
    }
}
