using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleImageGallary.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Upload()
        {
             return View();
        }
    }
}
