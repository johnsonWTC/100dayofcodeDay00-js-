using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WapApi02.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WapApi02.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public static List<User> users = new List<User>();

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
             User user = users.FirstOrDefault(c => c.userID == id);

            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            users.Add(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}/{name}")]
        public void Put(int id, string name)
        {
            User user = users.FirstOrDefault(c => c.userID == id);
            user.UerName = name;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
