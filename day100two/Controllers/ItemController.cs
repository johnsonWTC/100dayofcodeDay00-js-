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
            //users
            User user = new User();
            user.userName = "Thandwelihle";
            User userTwo = new User();
            userTwo.userName = "johnson";


            //items
            Item item = new Item();
            item.itemName = "books";
            Item itemTwo = new Item();
            itemTwo.itemName = "laptop";

            
           



            return View();
        }
    }
}
