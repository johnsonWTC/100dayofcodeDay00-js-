using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallary.Models;
using SimpleImageGallery.Data.Models;
using SimpleImageGallery.Services;

namespace SimpleImageGallary.Controllers
{
    public class GalleryController : Controller
    {
        private readonly Image _imageService;
        public GalleryController(Image imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {
            var hickingImages = new List<ImageTag>();
         
            var imageList = ImageService.
            return View(model  );
        }
    }
}
