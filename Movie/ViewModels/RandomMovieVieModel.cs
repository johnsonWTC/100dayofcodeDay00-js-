﻿using Movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.ViewModels
{
    public class RandomMovieVieModel
    {
        public Show Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
