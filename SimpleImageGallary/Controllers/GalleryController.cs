using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallary.Models;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallary.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            GalleryImage galleryImage1 = new GalleryImage();
            GalleryImage galleryImage2 = new GalleryImage();
            GalleryImage galleryImage3 = new GalleryImage();

            galleryImage1.Title = "image one";
            galleryImage1.Created = 




            var model = new GalleryIndexModel();
            return View(model  );
        }
    }
}
