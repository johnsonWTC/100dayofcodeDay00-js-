﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallary.Models;

namespace SimpleImageGallary.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel();
            return View(model);
        }
    }
}
