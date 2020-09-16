using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var userOne = new User();
            userOne.userName = "jam";

            var userTwo = new User();
            userTwo.userName = "johnson";
            var userList = new List<User>();
            userList.Add(userOne);
            userList.Add(userTwo);






            var itemOne = new Item();
            itemOne.ItemName = "book";

            var itemTwo = new Item();
            itemTwo.ItemName = "laptop";
            var itemList = new List<Item>();
            itemList.Add(itemOne);
            itemList.Add(itemTwo);







            TestViewModel testViewModel = new TestViewModel();
            testViewModel.ListOfItems = itemList;
            
            return View(testViewModel);
        }
    }
}
