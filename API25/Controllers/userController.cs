using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API25.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        // GET: api/<userController>

        public static List<User> users = new List<User>();
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET api/<userController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = users.FirstOrDefault(e => e.userID == id);
            
            return user;
        }

        // POST api/<userController>
        [HttpPost]
        public void Post([FromBody] User  user)
        {
            users.Add(user);
        }

        // PUT api/<userController>/5
        [HttpPut("{id}/{newName}")]
        public void Put(int id, string newName)
        {
            User user = users.FirstOrDefault(e => e.userID == id);
        }

        // DELETE api/<userController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
