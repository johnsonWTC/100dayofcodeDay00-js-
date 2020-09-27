using coreAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace coreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
       
         private static List<Character> characters = new List<Character>() {
        new Character(),
        new Character{Name = "Thandelihle" ,id =1 }


      };
            public IActionResult Getall()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }

        [HttpPost]
        public IActionResult addCharector(Character character)
        {
            characters.Add(character);
            return Ok(characters);
        }

        [HttpPut("{id}/{name}")]
        public IActionResult editCharacter(string name, int id)
        {
            Character character = characters.FirstOrDefault(c => c.id == id);
            character.Name = name;
            return Ok(character);
        }


    }
}
