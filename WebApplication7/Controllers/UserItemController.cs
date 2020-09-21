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

        public IActionResult User()
        {
            Item item = new Item();
            item.itemName = "book";

            Item itemTwo = new Item();
            itemTwo.itemName = "Laptop";
            List<Item> itemsFromList = new List<Item>();
            itemsFromList.Add(item);
            itemsFromList.Add(itemTwo);

           

            User user = new User();
            user.userName = "Johnson";

            UserItemViewModel userItemViewModel = new UserItemViewModel();
            userItemViewModel.items = itemsFromList;
            userItemViewModel.user = user;

            return View(userItemViewModel);
        }
    }
}
