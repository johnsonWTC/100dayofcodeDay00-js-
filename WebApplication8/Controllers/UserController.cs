using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User userOne = new User();
            User userTwo = new User();
            User userThree = new User();
            User userFour = new User();
            User userFive = new User();
            User userSix = new User();
            User userSeven = new User();
            return View();
        }
    }
}
