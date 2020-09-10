using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class ItemViewModel
    {
        public Item item { get; set; }
        public List<Item> items { get; set; }
    }
}
