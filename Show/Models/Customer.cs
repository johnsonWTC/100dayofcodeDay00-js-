﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Show.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name  { get; set; }
        public bool isSubsribedToNewsLetter { get; set; }
    }
}