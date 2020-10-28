﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE07.Models
{
    public class BookContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
