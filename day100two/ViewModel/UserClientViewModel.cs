using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day100two.Models;

namespace day100two.ViewModel
{
    public class UserClientViewModel
    {
        public User user { get; set; }
        public List<User> Users { get; set; }

        public Item item { get; set; }
        public List<Item> Items { get; set; }
    }
}
