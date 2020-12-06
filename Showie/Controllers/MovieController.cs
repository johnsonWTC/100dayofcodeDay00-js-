using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Showie.Models;
using Showie.ShowViewModel;

namespace Showie.Controllers
{
    public class MovieController : Controller
    {
        // GET: RandomController
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





            ViewModel viewModel = new ViewModel();

         
            viewModel.Movie = movie;
            viewModel.Customers = customers;

            return View(viewModel);
        }

        // GET: RandomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RandomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RandomController/Create
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

        // GET: RandomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RandomController/Edit/5
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

        // GET: RandomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RandomController/Delete/5
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
    }
}
