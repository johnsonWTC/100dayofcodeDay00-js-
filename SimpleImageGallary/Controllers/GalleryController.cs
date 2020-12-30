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
            var hickingImages = new List<ImageTag>();
            var cityImages = new List<ImageTag>();

            var imageTagOne = new ImageTag();
            var imageTagTwo = new ImageTag();
            var imageTagThree = new ImageTag();




            GalleryImage galleryImage1 = new GalleryImage();
            GalleryImage galleryImage2 = new GalleryImage();
            GalleryImage galleryImage3 = new GalleryImage();

            galleryImage1.Title = "image one";
            galleryImage1.Created = DateTime.Now;
            galleryImage1.Tags = hickingImages; 
            
            galleryImage2.Title = "image two";
            galleryImage2.Created = DateTime.Now;
            galleryImage2.Tags = cityImages;
            
            galleryImage3.Title = "image three";
            galleryImage3.Created = DateTime.Now;
            galleryImage3.Tags = hickingImages;




            var model = new GalleryIndexModel();
            return View(model  );
        }
    }
}
