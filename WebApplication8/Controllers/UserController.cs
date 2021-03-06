﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.ViewModel;

namespace WebApplication8.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Users()
        {
            User userOne = new User();
            userOne.userID = 1;
            userOne.userName = "jam";
            userOne.userAge = 20;

            User userTwo = new User();
            userTwo.userID = 2;
            userTwo.userName = "jamizzy";
            userTwo.userAge = 22;

            User userThree = new User();
            userThree.userID = 3;
            userThree.userName = "johnson";
            userThree.userAge = 23;


            User userFour = new User();
            userFour.userID = 4;
            userFour.userName = "thandwelihle";
            userFour.userAge = 3;

 


            List<User> users = new List<User>();
            users.Add(userOne);
            users.Add(userTwo);
            users.Add(userThree);
            users.Add(userFour);

            UserViewModel userViewModel = new UserViewModel();
            userViewModel.Users = users;


            return View(userViewModel);
        }
    }
}
