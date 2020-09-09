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
          
            var imageList = _imageService.GetAll();
            var galleryIndexModel = new GalleryIndexModel();
            galleryIndexModel.Images = imageList;
            return View(galleryIndexModel);
        }


        public IActionResult Deatils( int id)
        {
            var image = _imageService.GetGalleryById(id);
            var ImageViewModel = 
        }
    }
}
