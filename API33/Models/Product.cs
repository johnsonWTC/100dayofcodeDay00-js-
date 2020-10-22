using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API33.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
    }
}
