using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF05.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF05.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        UserContext _context = new UserContext();
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = _context.Users.FirstOrDefault(e => e.userID == id);
            return user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User User)
        {
            _context.Users.Add(User);
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
