using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {

        private static List<User> Users = new List<User>() {
        new User(),
        new User{Name = "Thandelihle" ,id =1 }


      };
        public IActionResult Getall()
        {
            return Ok(Users);
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            return Ok(Users.FirstOrDefault(c => c.id == id));
        }

        [HttpPost]
        public IActionResult addCharector(User user)
        {
            Users.Add(user);
            return Ok(Users);
        }

        [HttpPut("{id}/{name}")]
        public IActionResult editCharacter(string name, int id)
        {
            User character = Users.FirstOrDefault(c => c.id == id);
            character.Name = name;
            return Ok(character);
        }


    }

}
