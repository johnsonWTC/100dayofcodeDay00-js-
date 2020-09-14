using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            Items book = new Items();
            book.itemName = "book";
            List<Items> items = new List<Items>();
            items.Add(book);

            return View(items);
        }
    }
}
