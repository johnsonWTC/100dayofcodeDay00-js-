using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test01.Models;

namespace test01.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            user johnson = new user();
            johnson.userID = 1;
            johnson.userName = "johnson";

            user thandwelihle = new user();
            thandwelihle.userName = "thandwelihle";
            thandwelihle.userID = 2;

            item book = new item();
            book.itemID = 1;
            book.itemName = 2;
            return View();
        }
    }
}
