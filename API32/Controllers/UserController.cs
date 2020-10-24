using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API29.Data;
using API32.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API32.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static LinkedList<User> users = new LinkedList<User>();

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
          
           
            using (var _context = new Context())
            {
                User user = _context.Users.FirstOrDefault(e => e.userID == id);
                return user;
            }
          

        
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            using ( var _context = new Context()){
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
