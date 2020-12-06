﻿using Showie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Showie.ShowViewModel
{
    public class ViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }

        public Movie Movie { get; set; }
    }
}