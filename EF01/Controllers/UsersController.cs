using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF01.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
       public static List<User> usersList = new List<User>();
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using (var _context = new UserContext())
            {
                List<User> users = _context.Users.ToList();

            }
            return usersList;
        }


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            using (var _context = new UserContext())
            {
                User user = _context.Users.FirstOrDefault(e => e.userID == id);
                return user;
              
            }
           
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            using (var _context = new UserContext())
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
