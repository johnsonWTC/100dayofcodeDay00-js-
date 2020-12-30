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

            imageTagOne.Discription = "urban";
            imageTagOne.Id = 0;

            imageTagTwo.Discription = "Adveture";
            imageTagTwo.Id = 1;

            imageTagThree.Discription = "kasi";
            imageTagThree.Id = 2;

            hickingImages.Add(imageTagOne);
            hickingImages.Add(imageTagTwo);
            cityImages.Add(imageTagThree);


            var ImageList = new List<GalleryImage>();

            GalleryImage galleryImage1 = new GalleryImage();
            GalleryImage galleryImage2 = new GalleryImage();
            GalleryImage galleryImage3 = new GalleryImage();

            galleryImage1.Title = "Hicking Trip";
            galleryImage1.Created = DateTime.Now;
            galleryImage1.Tags = hickingImages; 
            
            galleryImage2.Title = "On the trail";
            galleryImage2.Created = DateTime.Now;
            galleryImage2.Tags = cityImages;
            
            galleryImage3.Title = " ";
            galleryImage3.Created = DateTime.Now;
            galleryImage3.Tags = hickingImages;


            ImageList.Add(galleryImage1);
            ImageList.Add(galleryImage2);
            ImageList.Add(galleryImage3);







            var model = new GalleryIndexModel();
            return View(model  );
        }
    }
}
