using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API13.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> users = new List<User>();
        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = users.FirstOrDefault(e => e.userID == id);
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            users.Add(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}/{newName}")]
        public void Put(int id, string newName)
        {
            User user = users.FirstOrDefault(e => e.userID == id);
            user.userName = newName;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            User user = users.FirstOrDefault(e => e.userID == id);
            users.Remove(user);
        }
    }
}
