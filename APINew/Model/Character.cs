using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINew.Model
{
    public class Character
    {
        public int id { get; set; }
        public string Name { get; set; } = "Jam";
        public int Hitpoints { get; set; } = 100;
        public int Strength { get; set; }
    }
}
