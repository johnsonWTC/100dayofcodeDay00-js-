using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF10.Models;

namespace EF10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SchoolContext schoolContext = new SchoolContext();
        public HomeController(ILogger<HomeController> logger)
        {
           
            _logger = logger;
        }

        public IActionResult Index()
        {

            Student student = new Student();
            student.studentName = "thandwelihle";
         
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
