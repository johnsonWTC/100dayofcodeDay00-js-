﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.ViewModel
{
    public class UserItemViewModel
    {
        public User user { get; set; }
        public Item item { get; set; }

        public List<Item>  items{ get; set; }
      
    }
}
