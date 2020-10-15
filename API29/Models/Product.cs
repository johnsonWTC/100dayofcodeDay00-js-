﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API29.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
    }
}
