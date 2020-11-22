using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleImageGallary.Controllers
{
    public class Gallery : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
