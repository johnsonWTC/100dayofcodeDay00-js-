using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movie.Controllers
{
    public class CastomerController : Controller
    {
        // GET: CastomerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CastomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CastomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CastomerController/Create
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

        // GET: CastomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CastomerController/Edit/5
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

        // GET: CastomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CastomerController/Delete/5
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
