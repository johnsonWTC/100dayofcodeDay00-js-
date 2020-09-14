using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ModelView;

namespace WebApplication3.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            Items book = new Items();
            book.itemName = "book";
            Items laptop = new Items();
            laptop.itemName = "laptop";


            ItemModelView itemModelView = new ItemModelView();
            itemModelView.Items.Add(book);
            itemModelView.Items.Add(laptop);
          


            return View(itemModelView);
        }
    }
}
