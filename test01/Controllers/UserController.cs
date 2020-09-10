using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test01.Models;
using test01.ViewModel;

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

            List<user> users = new List<user>();
            users.Add(johnson);
            users.Add(thandwelihle);

            item book = new item();
            book.itemID = 1;
            book.itemName = "book";

            item cup = new item();
            cup.itemID = 2;
            cup.itemName = "cup";

            List<item> items = new List<item>();
            items.Add(cup);
            items.Add(book);


            UserItemViewModel userItemViewModel = new UserItemViewModel();
            userItemViewModel.items = items;
            userItemViewModel.users = users;


            return View(userItemViewModel);
        }
    }
}
