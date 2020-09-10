using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            Item book = new Item();
            List<Item> Books = new List<Item>();
            Books.Add(book);
            ItemViewModel itemViewModel = new ItemViewModel();
            itemViewModel.items = Books;
          
            return View(itemViewModel);
        }
    }
}
