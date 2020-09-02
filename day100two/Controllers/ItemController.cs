using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using day100two.Models;

namespace day100two.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            Item item = new Item();

            item.itemName = "books";

            User userTwo = new User();
            userTwo.userName = "johnson";

            return View();
        }
    }
}
