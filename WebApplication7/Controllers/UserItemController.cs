using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using WebApplication7.ViewModel;

namespace WebApplication7.Controllers
{
    public class UserItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserItem()
        {
            Item item = new Item();
            item.itemName = "book";

            Item itemTwo = new Item();
            itemTwo.itemName = "Laptop";
            List<Item> items = new List<Item>();
            items.Add(item);
            items.Add(itemTwo);

            User user = new User();
            user.userName = "Johnson";



            return View();
        }
    }
}
