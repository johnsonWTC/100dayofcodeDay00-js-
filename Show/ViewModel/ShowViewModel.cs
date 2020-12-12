﻿using Show.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Show.ViewModel
{
    public class ShowViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }

        public Movie Movie { get; set; }
    }
}