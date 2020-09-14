using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User userOne = new User();
            userOne.userName = "johnson";
            return View(userOne);
        }
    }
}
