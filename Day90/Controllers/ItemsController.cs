using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day90.Models;

namespace Day90.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Items()
        {
            Items item = new Items();
            item.itemName = "Book";
            return View(item);
        }
    }
}
