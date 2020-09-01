using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using day100.Models;
using day100.ViewModel;

namespace day100.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie();
            movie.MovieName = "Day 100";
            var clientList = new List<Clients>();
            Clients johnson = new Clients();
            johnson.ClientName = "johnson";
            clientList.Add(johnson);
            Clients thandwelihle = new Clients();
            thandwelihle.ClientName = "thandwelihle";
            ClientMovieViewModel clientMovieViewModel = new ClientMovieViewModel();
            clientMovieViewModel.movie = movie;
            clientMovieViewModel.clients = clientList;
       

            return View(movie);

        }
    }
}
