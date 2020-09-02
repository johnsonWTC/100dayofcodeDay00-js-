using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using day100two.Models;
using day100two.ViewModel;

namespace day100two.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(string sortOder)
        {
            //users
            User user = new User();
            user.userName = "Thandwelihle";
            User userTwo = new User();
            userTwo.userName = "johnson";
            ViewBag.itemParam = String.IsNullOrEmpty(sortOder) ? "itemDesc" : "";




            List<User> usersList = new List<User>();
            usersList.Add(user);
            usersList.Add(userTwo);


            //items
            Item item = new Item();
            item.itemName = "books";
            Item itemTwo = new Item();
            itemTwo.itemName = "laptop";

            List<Item> itemList = new List<Item>();
            itemList.Add(item);
            itemList.Add(itemTwo);


            if (sortOder == "itemDesc")
            {
                itemList = itemList.OrderByDescending((o => o.itemName)).ToList();
            }
            else{
                itemList = itemList.OrderBy(o => o.itemName).ToList();
            }

            UserClientViewModel userClientViewModel = new UserClientViewModel();

            userClientViewModel.item = item;
            userClientViewModel.Items = itemList;

            userClientViewModel.user = user;
            userClientViewModel.Users = usersList;
           

            return View(userClientViewModel);
        }
    }
}
